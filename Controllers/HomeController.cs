using Microsoft.AspNetCore.Mvc;
using model_homework.Models.Customers.Entities;

namespace model_homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<About> about=new List<About>() {
                new About(){Id=1 ,Title="Our Vision",Description="Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra" } ,
                new About(){Id=2 ,Title="Our Mission",Description="Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis"},
                new About(){Id=3 ,Title="Our Goal",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor."}
            };    


            return View(about);
        }
    }
}
