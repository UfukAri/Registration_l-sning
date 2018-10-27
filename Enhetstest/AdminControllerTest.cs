using System;
using System.Linq;
using System.Web.Mvc;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Registration_løsning.Controllers;

namespace Enhetstest
{
    [TestClass]
    public class AdminControllerTest
    {
        [TestMethod]
        public void EditFilm()
        {
            var controller = new AdminController(new AdminRepositoryStub());

            var actionResult = (ViewResult)controller.Edit(1);

            Assert.AreEqual(actionResult.ViewName, "");
        }

        [TestMethod]
        public void EditFilm_Ikke_Funnet_Ved_View()
        {
            var controller = new AdminController(new AdminRepositoryStub());

            var actionResult = (ViewResult)controller.Edit(0);
            var kundeResultat = (Film)actionResult.Model;

            Assert.AreEqual(actionResult.ViewName, "");
            Assert.AreEqual(kundeResultat.Id, 0);
        }

        [TestMethod]
        public void SlettFilm()
        {
            // Arrange
            var controller = new AdminController(new AdminRepositoryStub());

            // Act
            var actionResult = (ViewResult)controller.Slett(1);
            var resultat = (Film)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
        }

        [TestMethod]
        public void Slettet_funnet_Post()
        {
            // Arrange
            var controller = new AdminController(new AdminRepositoryStub());
            var innFilm = new Film()
            {
                Id = 1,
                Title = "Logan",
                Pris= 120,
                Catrgory = "Action",
                Discription = "Logan is awesome",
                Image = "Oslo"
            };


            // Act
            var actionResult = (RedirectToRouteResult)controller.Slett(innFilm.Id);

            // Assert
            Assert.AreEqual(actionResult.RouteName, "");
            Assert.AreEqual(actionResult.RouteValues.Values.First(), "FilmListe");
        }

        [TestMethod]
        public void Slett_ikke_funnet_Post()
        {
            // Arrange
            var controller = new AdminController(new AdminRepositoryStub());
            var innFilm = new Film()
            {
                Id = 0,
                Title = "Logan",
                Pris = 120,
                Catrgory = "Action",
                Discription = "Logan is awesome",
                Image = "Oslo"
            };


            // Act
            var actionResult = (ViewResult)controller.Slett(innFilm.Id);

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
        }

        [TestMethod]
        public void LeggFilm()
        {
            // Arrange
            var controller = new AdminController(new AdminRepositoryStub());

            // Act
            var film = new Film();
            film.Id = 1;
            var actionResult = (ViewResult)controller.Leggfilm(film);
            var resultat = (Film)actionResult.Model;

            // Assert
            Assert.AreEqual(actionResult.ViewName, "");
        }
    }
}
