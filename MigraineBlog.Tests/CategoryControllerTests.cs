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

        public CategoryControllerTests()
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
        [Fact]
        public void Index_Passes_AllCourses_To_View()
        {
            // Arrange
            var expectedCategories = new List<Category>();
            categoryMockRepo.GetAll().Returns(expectedCategories);

            // Act
            var result = controller.Index();

            // Assert
            Assert.Equal(expectedCategories, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            // Act
            var result = controller.Details(1);

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            // Arrange
            var expectedCategory = new Category();
            categoryMockRepo.GetById(1).Returns(expectedCategory);

            // Act
            var result = controller.Details(1);

            // Assert
            Assert.Equal(expectedCategory, result.Model);
        }
    }
}
