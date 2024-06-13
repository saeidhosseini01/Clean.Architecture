using Clean.Architecture.Application.Interface;
using Clean.Architecture.Application.Interface.UserRepository;
using Clean.Architecture.Domain.Entitis.Users;





using Clean.Architecture.Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infrastructure.Persistence.Services.UserReppository
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {
        protected readonly DataDbContext _dbContext;
        public UserRepository(DataDbContext dbcontext)
        {
                _dbContext = dbcontext;
        }
        public Users GetUserByGuId(Guid guid)
        {
            throw new NotImplementedException();
        }

       
    }
}
