using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using chemex.Util;
using chemex.ViewModels;
using chemex.Models;
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
                        return Json(ResultModel.ResultOK());
                    }
                    return Json(ResultModel.ResultError("Пользователь не найден"));
                }
            }
            return Json(ResultModel.ResultError("Ошибка валидации на стороне сервера"));
        }

        [Route("/register")]
        [HttpGet]
        public async Task<JsonResult> Registration(UserRigisterModel model)
        {
            if (ModelState.IsValid)
            {
                using (ApplicationContext app = new ApplicationContext())
                {
                    var user = await app.Users.FirstOrDefaultAsync(u => u.Email == model.Email || u.Login == model.Login);                    
                    if(user != null)
                    {
                        return Json(ResultModel.ResultError("Email or login is used"));
                    }

                    User newUser = new User { Email = model.Email, Login = model.Login, Password = model.Password};
                    await app.Users.AddAsync(newUser);

                    var claims = new List<Claim> { 
                        new Claim(ClaimsIdentity.DefaultNameClaimType, model.Login)
                    };
                    ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));

                    return Json(ResultModel.ResultOK());
                }
            }
            return Json(model);
        }
    }
}