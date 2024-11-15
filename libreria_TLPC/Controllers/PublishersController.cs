using libreria_TLPC.Data.Services;
using libreria_TLPC.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libreria_TLPC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublishersService _publishersServices;
        public PublishersController(PublishersService publishersServices)
        {
            _publishersServices = publishersServices;
        }
        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            _publishersServices.AddPublisher(publisher);
            return Ok();
        }
    }
}