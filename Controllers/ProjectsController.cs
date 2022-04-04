using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using chemex.ViewModels;
using chemex.Util;
using chemex.Models;
using System.Linq;

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
                    User CurrentUser = await app.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
                    if (CurrentUser == null)
                        return Json(ResultModel.ResultError("not authorised user"));
                    
                    var Project = new Project
                    {
                        Name = model.Name,
                        CreationTime = DateTime.Now,
                        LastModifiedTime = DateTime.Now,
                        UserId = CurrentUser.Id
                    };
                    app.Projects.Add(Project);
                    app.SaveChanges();
                    return Json(ResultModel.ResultOK());
                }
            }
            return Json(ResultModel.ResultError("Model isnt valid"));
        }

        [Route("/projectRemoving")]
        [HttpGet]
        public async Task<JsonResult> RemoveProject(int projectID)
        {
            using (ApplicationContext app = new ApplicationContext())
            {
                Project? project = await app.Projects.FirstOrDefaultAsync(u => u.Id == projectID);
                if (project == null)
                    return Json(ResultModel.ResultError("project doesnt exist"));

                app.Projects.Remove(project);
                app.SaveChanges();
                return Json(ResultModel.ResultOK());
                
            }
        }

        [Route("/projectChanging")]
        public async Task<JsonResult> ChangeProject(int projectID, string newName)
        {
            using (ApplicationContext app = new ApplicationContext())
            {
                Project project = await app.Projects.FirstOrDefaultAsync(p => p.Id == projectID);
                if (project == null)
                    return Json(ResultModel.ResultError("project doesnt exist"));
                project.Name = newName;
                project.LastModifiedTime = DateTime.Now;
                await app.SaveChangesAsync();
                return Json(ResultModel.ResultOK());
            }
        }

        [Route("/updateLastModifiedTime")]
        public async Task<JsonResult> UpdateLastModifiedTime(int projectID)
        {
            using (ApplicationContext app = new ApplicationContext())
            {
                Project project = await app.Projects.FirstOrDefaultAsync(p => p.Id == projectID);
                if (project == null)
                    return Json(ResultModel.ResultError("project doesnt exist"));
                project.LastModifiedTime = DateTime.Now;
                await app.SaveChangesAsync();
                return Json(ResultModel.ResultOK());
            }
        }

        [Route("/projectList")]
        public async Task<JsonResult> GetProjectList(int id)
        {
            using (ApplicationContext app = new ApplicationContext())
            {
                var user = await app.Users.Include(u => u.Projects).FirstOrDefaultAsync(u => u.Id == id);
                if (user == null)
                    return Json(ResultModel.ResultError("user not found"));
                var projects = user.Projects.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.CreationTime,
                    p.LastModifiedTime
                });
                return Json(ResultModel.ResultOK(projects));
            }
        }
    }
}
