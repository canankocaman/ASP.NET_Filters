using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filtreleme.Models
{
    public class LogVeri
    {
        private static List<LogBilgi> _loglar = new List<LogBilgi>();
        //log verileri Loglar listesinde tutulacak.
        public static List<LogBilgi> Loglar
        {
            //action başlamadan veya tamamlandığında dönen logları al anlamına gelmeketdir.
            get { return _loglar; }
        }
    }
}