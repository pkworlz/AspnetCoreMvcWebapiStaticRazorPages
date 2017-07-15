using Microsoft.AspNetCore.Mvc;


namespace aspnetIS4.Controllers
{
    [Route("api/[controller]")]
    public class MessageServiceController : Controller
    {
       
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "[\"Message1\",\"Message2\"]";
        }
    }


}