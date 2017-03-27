using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MpathY.Models;
using MpathY.ViewModels;

namespace MpathY.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SearchBtn(SearchByTypeReq req)
        {
            
            return View(req);
        }

       // OleDbConnection myConn = dbconn.GetConnection();
        
    }
}