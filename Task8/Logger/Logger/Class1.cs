using System.IO;
using System.Net;
using System.Diagnostics;
using System;
using System.Xml;

namespace Logger
{
    public class log
    {
        public static string strLogFilePath = string.Empty;
        private static StreamWriter sw = null;
        /// <summary>
        /// Setting LogFile path. If the logfile path is 
        /// null then it will update error info into LogFile.txt under
        /// application directory.
        /// </summary>
        public string LogFilePath
        {
            set
            {
                strLogFilePath = value;
            }
            get
            {
                return strLogFilePath;
            }
        }

        /// <summary>
        /// Write error log entry for window event if the bLogType is true.
        /// Otherwise, write the log entry to
        /// customized text-based text file
        /// </summary>
        /// <param name="bLogType"></param>
        /// <param name="objException"></param>
        /// <returns>false if the problem persists</returns>
        public static bool ErrorRoutine(bool bLogType, Exception objException)
        {
            try
            {
                //Check whether logging is enabled or not
                bool bLoggingEnabled = false;

                bLoggingEnabled = CheckLoggingEnabled();

                //Don't process more if the logging 
                if (false == bLoggingEnabled)
                    return true;

                //Write to Windows event log
                if (true == bLogType)
                {
                    string EventLogName = "ErrorSample";

                    if (!EventLog.SourceExists(EventLogName))
                        EventLog.CreateEventSource(objException.Message,
                        EventLogName);

                    // Inserting into event log
                    EventLog Log = new EventLog();
                    Log.Source = EventLogName;
                    Log.WriteEntry(objException.Message,
                             EventLogEntryType.Error);
                }
                //Custom text-based event log
                else
                {
                    if (false == CustomErrorRoutine(objException))
                        return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        ///<summary>
        /// If the LogFile path is empty then, it will write the log entry to 
        /// LogFile.txt under application directory.
        /// If the LogFile.txt is not availble it will create it
        /// If the Log File path is not empty but the file is 
        /// not availble it will create it.
        /// <param name="objException"></param>
        /// <RETURNS>false if the problem persists</RETURNS>
        ///</summary>
        private static bool CustomErrorRoutine(Exception objException)
        {
            string strPathName = string.Empty;

            if (strLogFilePath.Equals(string.Empty))
            {
                //Get Default log file path "LogFile.txt"
                strPathName = GetLogFilePath();
            }
            else
            {
                //If the log file path is not empty but the file
                //is not available it will create it
                if (true != File.Exists(strLogFilePath))
                {
                    if (false == CheckDirectory(strLogFilePath))
                        return false;

                    FileStream fs = new FileStream(strLogFilePath,
                            FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    fs.Close();
                }
                strPathName = strLogFilePath;
            }
            bool bReturn = true;

            // write the error log to that text file
            if (true != WriteErrorLog(strPathName, objException))
            {
                bReturn = false;
            }
            return bReturn;
        }


        /// <summary>
        /// Write Source,method,date,time,computer,error 
        /// and stack trace information to the text file
        /// 
        /// <param name="strPathName"></param>
        /// <param name="objException"></param>
        /// <RETURNS>false if the problem persists</RETURNS>
        ///</summary>
        private static bool WriteErrorLog(string strPathName,
                                        Exception objException)
        {
            bool bReturn = false;
            string strException = string.Empty;
            try
            {
                sw = new StreamWriter(strPathName, true);
                sw.WriteLine("Source        : " +
                        objException.Source.ToString().Trim());
                sw.WriteLine("Method        : " +
                        objException.TargetSite.Name.ToString());
                sw.WriteLine("Date        : " +
                        DateTime.Now.ToLongTimeString());
                sw.WriteLine("Time        : " +
                        DateTime.Now.ToShortDateString());
                sw.WriteLine("Computer    : " +
                        Dns.GetHostName().ToString());
                sw.WriteLine("Error        : " +
                        objException.Message.ToString().Trim());
                sw.WriteLine("Stack Trace    : " +
                        objException.StackTrace.ToString().Trim());
                sw.WriteLine("^^------------------------------------------------------------------ -^^ ");
        
                sw.Flush();
                sw.Close();
                bReturn = true;
            }
            catch (Exception)
            {
                bReturn = false;
            }
            return bReturn;
        }


        /// <summary>
        /// Check the log file in applcation directory.
        /// If it is not available, creae it
        /// 
        /// <RETURNS>Log file path</RETURNS>
        ///</summary>
        private static string GetLogFilePath()
        {
            try
            {
                // get the base directory
                string baseDir = AppDomain.CurrentDomain.BaseDirectory +
                               AppDomain.CurrentDomain.RelativeSearchPath;

                // search the file below the current directory
                string retFilePath = baseDir + "//" + "LogFile.txt";

                // if exists, return the path
                if (File.Exists(retFilePath) == true)
                    return retFilePath;
                //create a text file
                else
                {
                    if (false == CheckDirectory(strLogFilePath))
                        return string.Empty;

                    FileStream fs = new FileStream(retFilePath,
                          FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    fs.Close();
                }

                return retFilePath;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Create a directory if not exists
        /// 
        /// <param name="stLogPath"></param>
        ///<summary> <RETURNS></RETURNS>
        private static bool CheckDirectory(string strLogPath)
        {
            try
            {
                int nFindSlashPos = strLogPath.Trim().LastIndexOf("\\");
                string strDirectoryname =
                           strLogPath.Trim().Substring(0, nFindSlashPos);

                if (false == Directory.Exists(strDirectoryname))
                    Directory.CreateDirectory(strDirectoryname);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

//        <?xml version = "1.0" encoding="utf-8" ?> 
//<LoggingStatus>
//<LoggingEnabled>0</LoggingEnabled>
//</LoggingStatus>

//0 for disable logging
//1 for enable logging

/// <summary>
/// Check Logginstatus config file is exist.
/// If exist read the value set the loggig status
/// </summary>
        private static bool CheckLoggingEnabled()
        {
            string strLoggingStatusConfig = string.Empty;

            strLoggingStatusConfig = GetLoggingStatusConfigFileName();

            //If it's empty then enable the logging status 
            if (strLoggingStatusConfig.Equals(string.Empty))
            {
                return true;
            }
            else
            {

                //Read the value from xml and set the logging status
                bool bTemp = GetValueFromXml(strLoggingStatusConfig);
                return bTemp;
            }
        }

        /// <summary>
        /// Check the Logginstatus config under debug or 
        /// release folder. If not exist, check under 
        /// project folder. If not exist again, return empty string
        /// </summary>
        /// <RETURNS>empty string if file not exists</RETURNS>
        private static string GetLoggingStatusConfigFileName()
        {
            string strCheckinBaseDirecotry =
                      AppDomain.CurrentDomain.BaseDirectory +
                      "LoggingStatus.Config";

            if (File.Exists(strCheckinBaseDirecotry))
                return strCheckinBaseDirecotry;
            else
            {
                string strCheckinApplicationDirecotry =
                    GetApplicationPath() + "LoggingStatus.Config";

                if (File.Exists(strCheckinApplicationDirecotry))
                    return strCheckinApplicationDirecotry;
                else
                    return string.Empty;
            }
        }

        ///<summary> 
        /// Read the xml file and getthe logging status
        /// <param name="strXmlPath"></param>
        ///</summary> <RETURNS></RETURNS>
        private static bool GetValueFromXml(string strXmlPath)
        {
            try
            {
                //Open a FileStream on the Xml file
                FileStream docIn = new FileStream(strXmlPath,
                   FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                XmlDocument contactDoc = new XmlDocument();
                //Load the Xml Document
                contactDoc.Load(docIn);

                //Get a node
                XmlNodeList UserList =
                    contactDoc.GetElementsByTagName("LoggingEnabled");

                //get the value
                string strGetValue = UserList.Item(0).InnerText.ToString();

                if (strGetValue.Equals("0"))
                    return false;
                else if (strGetValue.Equals("1"))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
    
}
