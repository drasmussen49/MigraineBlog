using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MigraineBlog.Controllers;
using MigraineBlog.Models;
using NSubstitute;
using MigraineBlog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MigraineBlog.Tests
{
    public class CategoryControllerTests
    {
        CategoryController controller;
        IRepository<Category> categoryMockRepo;

        CategoryControllerTests()
        {
            categoryMockRepo = Substitute.For<IRepository<Category>>();
            controller = new CategoryController(categoryMockRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
