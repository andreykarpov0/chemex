using Microsoft.AspNetCore.Mvc;

namespace chemex.Controllers
{
    public class AccountController : Controller
    {
        [Route("/login")]
        public JsonResult Authorization(string login, string password = "321"){
            return Json(new Account() {Name = "Daniil", Password = "3221"});
        }

        public class Account{
            public string Name {get; set;}
            public string Password {get; set;}
        }
    }
}