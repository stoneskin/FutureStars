using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    using System.Web.Script.Serialization;

    using DTOs;
    using DTOs.API;

    using MockBL;

    using Newtonsoft.Json;

    public class MathController : Controller
    {
        //
        // GET: /Math/
        private IFutureStarAPI service;
       public MathController()
        {
            service = new FutureStarService();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Task()
        {
            return View();
        }

        public ContentResult TaskJsonP(string callback, int id, string token)
        {
            var model = service.GetTaskDetails(new TaskDetailRequest() { Id = id });
            //return Json(model, JsonRequestBehavior.AllowGet);
            return Content(
                String.Format("{0}({1});", callback, new JavaScriptSerializer().Serialize(model)),
                //new JsonSerializer().Serialize(model)),
                "application/javascript");
        }

        public ContentResult UserInformJsonP(string callback, DTOs.UserAuthenticationRequest request)
        {
            var model = service.UserLogon(request);
            return Content(
                String.Format("{0}({1});", callback, 
                new JavaScriptSerializer().Serialize(model)),
                "application/javascript");
        }

        public ActionResult Test()
        {
            return View();
        }
        public ActionResult Report()
        {
            return View();
        }
    }
}
