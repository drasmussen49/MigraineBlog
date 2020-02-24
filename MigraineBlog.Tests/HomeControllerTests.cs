using Microsoft.AspNetCore.Mvc;
using MigraineBlog.Controllers;
using System;
using Xunit;

namespace MigraineBlog.Tests
{
    public class HomeControllerTests
    {

        public HomeControllerTests()
        {
            
        }
        
        [Fact]
        public void Index_Returns_A_View()
        {
            HomeController controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
