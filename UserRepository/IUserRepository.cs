using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }
}
