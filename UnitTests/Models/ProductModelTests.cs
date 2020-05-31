using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
using System.Text.Json;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProdutModel_Set_Date_Should_Be_Equal_To_9_15_2021()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Date = new DateTime(2021, 09, 15);

            //Assert
            Assert.AreEqual("9/15/2021", result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Should_Equal_Test()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "Unknown";

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Id_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Id_Should_Equal_10()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "10";

            // Assert
            Assert.AreEqual("10", result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Should_Equal_()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "Apple";

            // Assert
            Assert.AreEqual("Apple", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Image);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Should_Equal_ImgURL()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "Img/URL";

            // Assert
            Assert.AreEqual("Img/URL", result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Should_Equal_AppleOnlineWebsite()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "AppleOnlineWebsite";

            // Assert
            Assert.AreEqual("AppleOnlineWebsite", result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Title);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Should_Equal_AppleIpad()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "AppleIpad";

            // Assert
            Assert.AreEqual("AppleIpad", result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Description);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Should_Equal_AppleIpad()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "AppleIpad";

            // Assert
            Assert.AreEqual("AppleIpad", result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Should_Equal_2()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "2";

            // Assert
            Assert.AreEqual("2", result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Should_Equal_Delivered()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "Delivered!";

            // Assert
            Assert.AreEqual("Delivered!", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            for (int i = 0; i < result.Ratings.Length; i++)
            {
                Assert.AreEqual(5, result.Ratings[i]);
            }
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_Should_Equal_3()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 4;

            // Assert
            Assert.AreEqual(4, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_ToString_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            string ResultString = JsonSerializer.Serialize<ProductModel>(result);

            // Assert
            Assert.AreEqual(ResultString, result.ToString());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_RatingsEqualNull_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = null;

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_Default_Should_Equal_5()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_CountEquals_0_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_TotalEquals_0_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 0;

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

    }
}
