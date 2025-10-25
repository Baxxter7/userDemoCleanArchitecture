using Application.Dtos;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        
        [HttpGet("{name}")]
        public IActionResult Get([FromRoute] string name)
        {
            return Ok(_userService.Get(name));
        }
        
        [HttpGet]
        public IActionResult GetAll() =>  Ok(_userService.GetAll());
        
        [HttpPost]
        public IActionResult Post([FromBody] UserDto user)  =>  Ok(_userService.Add(user));
    }
}
