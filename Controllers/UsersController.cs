using BookRating.Application.InputModels;
using BookRating.Application.Services.Interfaces;
using BookRatingManager.Api.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace BookRating.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // api/users
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel inputModel)
        {
           
            var id = _userService.Create(inputModel);

                         
             return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }
        
    }
}
