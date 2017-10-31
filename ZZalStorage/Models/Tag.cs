using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZZalStorage.Models
{
    public enum Cat
    {
        gif, action, emotion
    }

    public class Tag
    {
        public int ID { get; set; }    
        public Cat? Cat { get; set; }
        public string Name { get; set; }        
    }
}
