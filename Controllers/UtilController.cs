using System.Collections.Generic;
using chemex.Util;
using chemex.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace chemex.Controllers
{
    public class UtilController : Controller
    {
        [Route("/rcreate")]
        [HttpGet]
        public JsonResult RecreateDatabase(){
            bool status = true;
            using(ApplicationContext app = new ApplicationContext()){
                status = app.Recreate();
            }
            return Json(status);
        }

        [Route("/gtlist")]
        [HttpGet]
        public JsonResult GetListPhones(){
            var data = new List<string>() {"123", "321", "GOGO"};
            return Json(ResultModel.ResultOK(data));
        }
    }
}