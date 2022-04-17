using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ourfitnessplan.Models
{
    public class tbl_Category
    {
        [Key]
        public int id { get; set; }

        public string category_name { get; set; }
    }
}