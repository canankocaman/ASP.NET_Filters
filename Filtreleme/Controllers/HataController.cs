using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtreleme.Controllers
{
    public class HataController : Controller
    {
        //
        // GET: /Hata/
        public ActionResult Index()
        {
            throw new FormatException();
        }
	}
}