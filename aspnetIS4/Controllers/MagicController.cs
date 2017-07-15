using Microsoft.AspNetCore.Mvc;


namespace aspnetIS4.Controllers
{
    [Route("[controller]")]
    public class MagicController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "[\"value1\",\"value2\"]";
        }
    }


}