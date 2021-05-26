using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Services.Implementations
{
    public class UserServiceImplementation : IUserService
    {
        public User Create(User user)
        {
            return user;
        }

        public List<string> FindByMail(string mail)
        {
            List<string> newlist = new List<string>();
            return newlist;
                //throw new NotImplementedException();
        }
    }
}
