using System;
using System.Runtime.Serialization;

namespace TamaService.Domain.Models
{
    [DataContract]
    public class Tamagotchi
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public short Hunger { get; set; }

        [DataMember]
        public short Sleep { get; set; }

        [DataMember]
        public short Boredom { get; set; }

        [DataMember]
        public short Health { get; set; }

        [DataMember]
        public Boolean isDead { get; set; }

        [DataMember]
        public DateTime CreationData { get; set; }

        [DataMember]
        public DateTime LastUpdate { get; set; }

        [DataMember]
        public TamaFlags Flags { get; set; }

        [DataMember]
        public int ImgId { get; set; }

        [DataMember]
        public DateTime ActionDone { get; set; }


        public int HoursPassed { get; set; }

        public string lastAction { get; set; }
    }
}