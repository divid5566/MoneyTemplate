using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyTemplate.Models
{
    public class note
    {
        public int category { get; set; }
        public DateTime noteday { get; set; }
        public int noteprice { get; set; }
        public string description { get; set; }


    }
}