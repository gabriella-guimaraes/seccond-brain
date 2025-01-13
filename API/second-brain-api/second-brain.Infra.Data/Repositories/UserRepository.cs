using second_brain.Domain.Entities;
using second_brain.Domain.Interfaces.Repositories;

namespace second_brain.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        //Buscas específicas
    }
}
