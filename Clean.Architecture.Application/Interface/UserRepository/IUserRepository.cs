using Clean.Architecture.Domain.Entitis.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Interface.UserRepository
{
    public interface IUserRepository:IBaseRepository<Users>,IUnitOfWork
    {
        Users GetUserByGuId(Guid guid);
    }
}
