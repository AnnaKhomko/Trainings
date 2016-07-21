using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Task7
{
    [Serializable()]
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        private List<Book> books;

        [XmlIgnore]
        public DateTime Date { get; set; }

        [XmlAttribute("date")]
        public string DateString {
            get { return this.Date.ToString("yyyy-MM-dd"); }
            set { this.Date = DateTime.Parse(value); }
        }

        [XmlElement("book")]
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
        
    }
}
