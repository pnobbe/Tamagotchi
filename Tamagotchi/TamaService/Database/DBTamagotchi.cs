﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string LastAction { get; set; }
    }
}