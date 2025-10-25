using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationContext _context;

    public UserRepository(ApplicationContext context)
    {
        _context = context;
    }
    
    public User? Get(string name)
    {
        return _context.Users.FirstOrDefault(u => u.Name == name);
    }

    public List<User>? GetAll() => _context.Users.ToList();

    public int Add(User user)
    {
        _context.Users.Add((user));
        var userId = _context.SaveChanges();
        return userId;
    }
}