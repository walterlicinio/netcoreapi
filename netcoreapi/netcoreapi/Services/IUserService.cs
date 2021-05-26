using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Services
{
    interface IUserService
    {
        User Create(User user);
        List<string> FindByMail(String mail);
    }
}
