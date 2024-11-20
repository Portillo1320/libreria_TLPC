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
        [HttpGet("get-publisher-book-with-authors/{id}")]
        public IActionResult GetPublisherData(int id)
        {
            var _response = _publishersServices.GetPublisherData(id);
            return Ok(_response);
        }
        [HttpDelete("delete-publisher-by-id/{id}")]
        public IActionResult DeletePublisherById(int id)
        {
            _publishersServices.DeletePublisherById(id);
            return Ok();
        }
    }
}