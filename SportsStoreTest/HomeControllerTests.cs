using Microsoft.AspNetCore.Mvc;
using Moq;
using SportsStoreMVC.Controllers;
using SportsStoreMVC.Models;
using SportsStoreMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace SportsStoreTest
{
     public class HomeControllerTests
    {
        /*
        [Fact]
        public void Index_IfProductValid_ReturnTrue()
        {
             var mock = new Mock<ISportsRepository>();
               mock.Setup(product => product.Products).Returns(
                (new List<Product>()
                {
                    new Product {ProductID = 1, Name = "P1"},
                   new Product {ProductID = 2, Name = "P2"}
                }).AsQueryable<Product>);
            var home = new HomeController(mock.Object);


            IEnumerable<Product> result =
            (home.Index(null) as ViewResult).ViewData.Model
              as IEnumerable<Product>;


            Assert.Equal(2, result.ToArray()[1].ProductID);

        }

        [Fact]
        public void Index_WhenCalled_ReturnsSpecifiedIndexItem()
        {
            var mock = new Mock<ISportsRepository>();
            mock.Setup(product => product.Products).Returns(
             (new List<Product>()
             {
                    new Product {ProductID = 1, Name = "P1"},
                   new Product {ProductID = 2, Name = "P2"},
                   new Product {ProductID = 3, Name = "P3"},
                   new Product {ProductID = 4, Name = "P4"}
             }).AsQueryable<Product>);
            var home = new HomeController(mock.Object);
            home._pageSize = 3;


            IEnumerable<Product> result =
            (home.Index(null,2) as ViewResult).ViewData.Model
              as IEnumerable<Product>;

            Assert.Equal("P4", result.ToArray()[0].Name);



        }

        [Fact]
        public void Index_BasedOnSelectedPage_ShowCorrectPageData()
        {
            // Arrange

            var mock = new Mock<ISportsRepository>();
            mock.Setup(m => m.Products).Returns((new List<Product>()
            {
                new Product {ProductID = 1, Name = "P1"},
               new Product {ProductID = 2, Name = "P2"},
               new Product {ProductID = 3, Name = "P3"},
             new Product {ProductID = 4, Name = "P4"},
                new Product {ProductID = 5, Name = "P5"}


            }).AsQueryable<Product>());
            var home = new HomeController(mock.Object) { _pageSize=2};


            //Act
            var x = home.Index(null,2).ViewData.Model as ProductViewModel;

            //Assert
            PageInfo p = x.PageInfo;
            Assert.Equal(5, p.TotalItems);


        }
        */


        [Fact]
        public void Index_WhenCategorySpecified_ReturnsProductsOfThatCategory()
        {
            var mock = new Mock<ISportsRepository>();
            mock.Setup(p => p.Products).Returns(
                (new List<Product>()
                {
                     new Product {ProductID = 1, Name = "P1",Category="a"},
               new Product {ProductID = 2, Name = "P2",Category="a"},
               new Product {ProductID = 3, Name = "P3",Category="b"},
             new Product {ProductID = 4, Name = "P4",Category="c"},
                new Product {ProductID = 5, Name = "P5",Category="a"}


                }).AsQueryable<Product>()
                ) ;
            var home = new HomeController(mock.Object);


           var model = home.Index("b").ViewData.Model as ProductViewModel;



            Assert.Equal(1, model.Products.Count());

        }





    }








}
