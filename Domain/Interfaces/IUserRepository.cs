using Domain.Entities;

namespace Domain.Interfaces;

public interface IUserRepository
{
    User? Get(string name);
    List<User>? GetAll();
    int Add(User user);
}