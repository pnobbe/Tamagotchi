using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TamaWebApp.Models
{
    public class Tamagotchi
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public short Hunger { get; set; }

        public short Sleep { get; set; }

        public short Boredom { get; set; }

        public short Health { get; set; }

        public Boolean isDead { get; set; }

        public DateTime CreationData { get; set; }

        public DateTime LastUpdate { get; set; }

        public TamaFlags Spelregels { get; set; }
    }
}