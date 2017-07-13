using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filtreleme.Models
{
    public class LogBilgi
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public DateTime IslemTarih { get; set; }
        public string Tip { get; set; }
    }
}