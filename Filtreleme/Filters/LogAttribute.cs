﻿using Filtreleme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtreleme.Filters
{
    public class LogAttribute : FilterAttribute, IActionFilter,IResultFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogVeri.Loglar.Add(new LogBilgi {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                IslemTarih = DateTime.Now,
                Tip = "Sonra"
            });
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogVeri.Loglar.Add(new LogBilgi{
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                IslemTarih = DateTime.Now,
                Tip = "Önce"
            });
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //IResultFilter interface'sinin eklenip implement edilmesiyle oluşur. İlgili action'ın sonucunun döndürülmesinden hemen önce çalışır. 
            LogVeri.Loglar.Add(new LogBilgi
            {

                Controller = filterContext.RouteData.Values["controller"].ToString(),
                Action = filterContext.RouteData.Values["action"].ToString(),
                IslemTarih = DateTime.Now,
                Tip = "Return'den sonra"
            });
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //IResultFilter interface'sinin eklenip implement edilmesiyle oluşur. İlgili action'ın sonucunun döndürülmesinden sonra çalışır. 
            LogVeri.Loglar.Add(new LogBilgi
            {

                Controller = filterContext.RouteData.Values["controller"].ToString(),
                Action = filterContext.RouteData.Values["action"].ToString(),
                IslemTarih = DateTime.Now,
                Tip = "Return'den önce"
            });
            
        }
    }
}