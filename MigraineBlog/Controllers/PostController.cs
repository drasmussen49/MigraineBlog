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
    }
}
