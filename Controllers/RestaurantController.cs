using Microsoft.AspNetCore.Mvc;

namespace restaurant_api_asp.net.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {

        [HttpGet]
        public int Create()
        {
            return 1;
        }
    }
}