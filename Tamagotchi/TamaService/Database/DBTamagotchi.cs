using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using TamaService.Domain.Interfaces;

namespace TamaService
{
    [Table("Tamagotchi")]
    public class DBTamagotchi
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

        public virtual DBTamaFlags Flags { get; set; }

        public int ImgId { get; set; }
        public DateTime ActionDone { get; set; }
    }
}