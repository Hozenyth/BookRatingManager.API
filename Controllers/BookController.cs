using BookRatingManager.Api.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace BookRatingManager.Api.Controllers
{
    [Route("api/BookRatingManager")]
    public class BookController : ControllerBase
    {

        public BookController() { }

        [HttpGet]
        public IActionResult GetBooks(string query)
        {
          
            return Ok();
        }

        [HttpGet("{isbn}")]
        public IActionResult GetBookByIsbn(string isbn)
        {
           
            return Ok();
        }

        [HttpGet("{id:int}", Name = "GetOtherById")]
        public IActionResult GetBookById(int id)
        {
           
            return Ok();
        }

        [HttpPost("CreateBook", Name = "CreateBook")]
        public IActionResult CreateBook([FromBody] CreateBookModel createBook, [FromServices] IValidator<CreateBookModel> validator)
        {

            var result = validator.Validate(createBook);
            var error = result.Errors.Select(e => e.ErrorMessage);

            if (!result.IsValid)
                return BadRequest(error);
            return Ok();
        }
                
    }
}
