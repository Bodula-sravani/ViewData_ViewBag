using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Demo.Tests
{
	[TestClass()]
	public class viewDataTests
	{
		[TestMethod()]
		public void viewDataTest()
		{
            //  Testing using ViewData 
			var controller = new HomeController();

			// Act
			var result = controller.Index() as ViewResult;

			// Assert
			Assert.AreEqual("Hey", result.ViewData["Message"]);
		}


        ////[TestMethod()]
        //public void viewBagTest()
        //{  // USing ViewBag - throws a compilation error
        //    // Arrange
        //    var controller = new HomeController();

        //    // Act
        //    var result = controller.Index() as ViewResult;
        //    Assert.AreEqual("Index", result.ViewName);
        //    // Assert
        //    Assert.AreEqual("Hello, World!", result.ViewBag.Message);
        //}
    }
}