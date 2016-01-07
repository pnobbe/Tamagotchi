using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TamaService
{
    [DataContract]
    public class TamaFlags
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public bool Crazy { get; set; }

        [DataMember]
        public bool Honger { get; set; }

        [DataMember]
        public bool Isolatie { get; set; }

        [DataMember]
        public bool Munchies { get; set; }

        [DataMember]
        public bool Slaaptekort { get; set; }

        [DataMember]
        public bool Topatleet { get; set; }

        [DataMember]
        public bool Vermoeidheid { get; set; }

        [DataMember]
        public bool Verveling { get; set; }

        [DataMember]
        public bool Voedseltekort { get; set; }

    }
}