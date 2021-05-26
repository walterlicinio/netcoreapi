using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Services
{
    public interface IUserService
    {
        User Create(User user); 
        User FindByMail(String mail);
    }
}
