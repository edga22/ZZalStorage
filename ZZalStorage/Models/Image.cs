using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZalStorage.Models
{
    public class Image
    {        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string FileName { get; set; }
        public DateTime AddDate { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
