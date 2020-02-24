using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraineBlog.Controllers
{
    public class CategoryController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
