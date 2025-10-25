using Application.Dtos;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User? Get(string name)
    {
        return _userRepository.Get(name);
    }

    public List<User>? GetAll() => _userRepository.GetAll();
    
    public int Add(UserDto user)
    {
        var userEntity = new User
        {
            Name = user.Name,
            Email = user.Email,
            Password = user.Password,
        };
        
        return _userRepository.Add(userEntity);
    }
}