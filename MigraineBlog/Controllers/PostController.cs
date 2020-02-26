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
        public ViewResult CreateByCategoryId(int id)
        {
            ViewBag.CategoryId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            postRepo.Create(post);
            return RedirectToAction("Details", "Category", new { id = post.CategoryId });
        }
        
    }
}
