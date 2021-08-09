using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using my_books.ActionResults;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublishersService _publishersService;
        public PublishersController(PublishersService publishersService)
        {
            _publishersService = publishersService;
        }

        [HttpPost("add-author")]
        public IActionResult AddBook([FromBody] PublisherVM publisher)
        {
            _publishersService.AddPublisher(publisher);
            return Ok();
        }
       /* [HttpGet("get-publisher-by-id/{id}")]
        public CustomActionResultVM GetPublisherById(int id)
        {
            var _response = _publishersService.GETPublisherById(id);
            if (_response != null)
            {
                // return Ok(_response);
                var _responsObj = new CustomActionResultVM()
                {
                    Publisher = _response
                };
                return new CustomActionResult(_responsObj);
                //return _response;

            }
            else
            {
                var _responsObj = new CustomActionResultVM()
                {
                    Exception = new Exception("This is coming from publisher controller")
                };
                return new CustomActionResult(_responsObj);
                // return NotFound()
            }
        }*/
        [HttpGet("get-publisher-books-with-authors/{id}")]
        public IActionResult GetPublisherData(int id)
        {
            var _response = _publishersService.GETPublisherData(id);
            return Ok(_response);
        }

        [HttpDelete("delete-publisher-by-id")]

        public IActionResult DeletePublisherByID(int id)
        {
            _publishersService.DeletePublisherByID(id);
            return Ok();
        }
    }
}
