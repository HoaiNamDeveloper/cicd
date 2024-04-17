using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Net.Http;
using System.Threading.Tasks;
namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            try
            {
                ViewBag.Message = "Your application descrtccn,nnon page.sql";

            }
            catch (SqlException e)
            {
                ViewBag.Message = e.Message.ToString();
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message.ToString() + "|sss" + e.StackTrace?.Substring(0, 300);
            }

            return View();
        }
      public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}