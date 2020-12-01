using Codiv19.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Repositories
{
    public interface ILoginRepository
    {
        public Login GetLogin(Login login);
    }
}
