using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV_Site_Grp19.Models
{
    public class Message
    {
        [Key]
        public int ID { get; set; }
        public string Content { get; set; }
    }
}