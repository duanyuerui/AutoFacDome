using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MAD.Models;
using MDA.IService;

namespace MAD.WebSite.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IBaseUserService _baseUserService;

        //public HomeController(IBaseUserService baseUserService)
        //{
        //    _baseUserService = baseUserService;
        //}

        public IBaseUserService BaseUserService { get; set; }

        public ActionResult Index()
        {
            string s = BaseUserService.Add();
            string a = BaseUserService.Dtl();
            var data = BaseUserService.Select();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}