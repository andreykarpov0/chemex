using chemex.Util;
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
    }
}