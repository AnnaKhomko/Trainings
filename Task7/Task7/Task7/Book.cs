﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task7
{
    [Serializable()]
    public class Book
    {
        [XmlIgnore]
        public DateTime PublishDate { get; set; }

        [XmlIgnore]
        public DateTime RegistrationDate { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date")]
        public string PublishDateString
        {
            get { return this.PublishDate.ToString("yyyy-MM-dd"); }
            set { this.PublishDate = DateTime.Parse(value); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date")]
        public string RegistrationDateString
        {
            get { return this.RegistrationDate.ToString("yyyy-MM-dd"); }
            set { this.RegistrationDate = DateTime.Parse(value); }
        }

        [XmlAttribute("id")]
        public string Id { get; set; }


    }


    
}
