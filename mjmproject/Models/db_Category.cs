using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mjmproject.Models
{
    
    public class db_Category
    {

        [Key]
        public long Id { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public long Parrent { get; set; }
        public DateTime LastModify { get; set; }

    }

    
}
