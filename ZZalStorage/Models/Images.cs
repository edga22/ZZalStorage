using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZZalStorage.Models
{
    public class Images
    {        
        public int ID { get; set; }
        public string FileName { get; set; }
        public DateTime AddDate { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
