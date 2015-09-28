using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerieDatabase
{
    [DataContract]
    public class SerieInfo
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime AirTime { get; set; }
        [DataMember]
        public string EpisodeName { get; set; }
        [DataMember]
        public int Season { get; set; }

    }
}
