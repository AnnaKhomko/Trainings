using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task7
{
    public enum Genre
    {
        [XmlEnum(Name = "Computer")]
        Computer,

        [XmlEnum(Name = "Science Fiction")]
        ScienceFiction,

        [XmlEnum(Name = "Horror")]
        Horror,

        [XmlEnum(Name = "Romance")]
        Romance,

        [XmlEnum(Name = "Fantasy")]
        Fantasy
    }
}
