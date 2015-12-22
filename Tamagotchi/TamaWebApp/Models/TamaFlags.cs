using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TamaWebApp.Models
{

    public class TamaFlags
    {
        [Key]
        public int TamaId { get; set; }

        public bool Crazy { get; set; }

        public bool Honger { get; set; }

        public bool Isolatie { get; set; }

        public bool Munchies { get; set; }

        public bool Slaaptekort { get; set; }

        public bool Topatleet { get; set; }

        public bool Vermoeidheid { get; set; }

        public bool Verveling { get; set; }

        public bool Voedseltekort { get; set; }

    }
}