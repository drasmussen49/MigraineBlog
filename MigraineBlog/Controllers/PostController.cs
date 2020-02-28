using Microsoft.AspNetCore.Mvc;
using MigraineBlog.Models;
using MigraineBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraineBlog.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postRepo;
        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;
        }
        public ViewResult Index()
        {
            var model = postRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = postRepo.GetById(id);
            return View(model);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CreateByCategoryId(int id, string categoryName)
        {
            ViewBag.CategoryId = id;
            ViewBag.CategoryName = categoryName;
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Post post)
        {
            postRepo.Create(post);
            return RedirectToAction("Details", "Category", new { id = post.CategoryId });
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            var model = postRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            postRepo.Update(post);
            return RedirectToAction("Details", "Category", new { id = post.CategoryId });
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = postRepo.GetById(id);
            return View(model);
        }
       
        [HttpPost]
        public ActionResult Delete(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var tempId = post.CategoryId;
            postRepo.Delete(post);
            return RedirectToAction("Details", "Category", new { id = tempId });
        }
    }
}
