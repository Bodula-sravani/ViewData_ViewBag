using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Controllers
{
	//public class person
	//{
	//	public int Id { get; set; }

	//	public string Name { get; set; }

	//	public DateTime DOB { get; set; }


	//}
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		//public HomeController()
		//{

		//}
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			// Passing a string   
		    ViewBag.Message = "Hai"; 
			ViewData["Message"] = "Hey";            // No casting is required in view


			//Passing a person model

			var p1 = new person() { Id = 1, Name = "person1", DOB = DateTime.Now };
			ViewBag.person = p1;
			ViewData["person"] = p1;                // Casting is required in view
			//return View();
            return RedirectToAction("Privacy");    //Redirection makes the properties null
        }

        public IActionResult Privacy()
		{


            Console.WriteLine("IN PRIVACY ACTION ViewBag: "+ViewBag.Message);
            Console.WriteLine("IN PRIVACY ACTION ViewData: "+ViewData["Message"]);
            return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}