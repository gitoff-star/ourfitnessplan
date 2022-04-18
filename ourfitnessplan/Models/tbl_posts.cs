using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ourfitnessplan.Models
{
    public class tbl_posts
    {
        [Key]
        public int id { get; set; }


        public string blogid { get; set; }

        [Required]
        public string title { get; set; }
        public string category { get; set; }
        
       // [DataType(DataType.Upload)]
        public string CoverImage { get; set; }

        [Required]
        [AllowHtml]
        [DataType(DataType.MultilineText)]
        public string content{ get; set; }

        public string tags { get; set; }

        public string aurthor { get; set; }


        public DateTime CreatedOn  { get; set; }

        public DateTime lastUpdated { get; set; }

      

        public bool deleteStatus { get; set; }

        

    }
}