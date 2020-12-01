using Codiv19.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Codiv19.API.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public Login GetLogin(Login login)
        {
            if (login.usuario == "ramos" && login.senha == "1234")
            {
                // criar contexto ai no banco de dados
                //fazer o consulta.
                login.id = 1;
                login.role = "administrador";
                return login;
            }
            return null;
        }
        
    }
}
