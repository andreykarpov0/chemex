using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using chemex.ViewModels;
using chemex.Util;
using chemex.Models;

namespace chemex.Controllers
{
    public class ProjectsController : Controller
    {
        [Route("/projectCreating")]
        [HttpGet]
        public async Task<JsonResult> CreateNewProject(ProjectHandlingModel model)
        {
            if (ModelState.IsValid)
            {
                using(ApplicationContext app = new ApplicationContext())
                {
                    //TODO: спросить нормально ли я получаю авторизованнного пользователя
                    User CurrentUser = await app.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
                    var Project = new Project 
                    { 
                        Name = model.Name,
                        CreationTime = DateTime.Now,
                        LastModifiedTime = DateTime.Now,
                        User = CurrentUser
                    };
                    app.Projects.Add(Project);
                    app.SaveChanges();
                    return Json(ResultModel.ResultOK(Project));
                }
            }
            return Json(ResultModel.ResultError("Model isnt valid"));
        }

        [Route("/projectRemoving")]
        [HttpGet]
        public async Task<JsonResult> RemoveProject(ProjectHandlingModel model)
        {
            using (ApplicationContext app = new ApplicationContext())
            {
                Project? project = await app.Projects.FirstOrDefaultAsync(u => u.Name == model.Name);
                if (project == null)
                {
                    app.Projects.Remove(project);
                    //TODO: спросить нудно ли отдельно удалять у Юзера
                    var user = await app.Users.FirstOrDefaultAsync(u => u.Login == project.User.Login);
                    user.Projects.Remove(project);
                    //
                    app.SaveChanges();
                    return Json(ResultModel.ResultOK());
                }
                return Json(ResultModel.ResultError("Несуществующее имя"));
            }
        }

        [Route("/projectList")]
        public async Task<JsonResult> GetProjectList()
        {
            using (ApplicationContext app = new ApplicationContext())
            {
                var user = await app.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
                return Json(ResultModel.ResultOK(user.Projects));
            }
                return Json(ResultModel.ResultError());
        }
    }
}
