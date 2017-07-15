using Microsoft.AspNetCore.Mvc;


namespace aspnetIS4.Controllers
{
    
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }
       
    }


}