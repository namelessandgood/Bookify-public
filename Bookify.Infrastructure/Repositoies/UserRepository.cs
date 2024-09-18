using Bookify.Domain.Users;

namespace Bookify.Infrastructure.Repositoies;

internal sealed class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}