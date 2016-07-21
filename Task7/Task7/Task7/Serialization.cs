using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Task7
{
    public class Serialization
    {

        public void Serialize(Catalog bookCollection)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

            //Add an empty namespace and empty value
            ns.Add("", "http://library.by/catalog");

            //Create the serializer
            XmlSerializer slz = new XmlSerializer(typeof(Catalog));
            using (FileStream fs = new FileStream(ResourceData.FilePathAfterSearealisation, FileMode.OpenOrCreate))
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = Encoding.UTF8;
                settings.Indent = true;
                using (var xw = XmlWriter.Create(fs, settings))
                {
                    slz.Serialize(xw, bookCollection, ns);
               }

            }
           
        }

    }
}
