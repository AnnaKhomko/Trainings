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
    public class Deserialization
    {
        public Catalog Deserialise()
        {

            Catalog catalog = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(Catalog));

            using (XmlReader reader = XmlReader.Create(ResourceData.FilePath))
            {
                catalog = (Catalog)deserializer.Deserialize(reader);
                reader.Close();
            }

            return catalog;
        }
        
    }
}
