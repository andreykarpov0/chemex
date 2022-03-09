using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using chemex.Util;
using chemex.ViewModels;
using Chemex.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace chemex.Controllers
{
    public class AccountController : Controller
    {
        [Route("/login")]
        [HttpGet]
        public async Task<JsonResult> Authorization(UserLoginModel model){
            if(ModelState.IsValid){
                using(ApplicationContext app = new ApplicationContext()){
                    var user = await app.Users.FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                    if(user != null){
                        // создаем один claim
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimsIdentity.DefaultNameClaimType, model.Login)
                        };
                        // создаем объект ClaimsIdentity
                        ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                        // установка аутентификационных куки
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
                        return Json("ok");
                    }
                }
            }
            return Json(model);
        }
    }
}