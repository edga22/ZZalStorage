using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZZalStorage.Models
{
    public enum Cata
    {
        gif, action, emotion
    }

    public class Tag
    {
        public int ID { get; set; }    
        public Cata? Cata { get; set; }
        public string Name { get; set; }        
    }
}
