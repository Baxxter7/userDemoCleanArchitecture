using System.ComponentModel.DataAnnotations;

namespace Application.Dtos;

public class UserDto
{
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
}