using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IApplicationUserDAO
    {
        //recebe o username e retorna o id de usuario
        public String getUserID(String userName);
    }
}
