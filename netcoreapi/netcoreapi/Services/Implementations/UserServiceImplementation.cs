using netcoreapi.Models;
using netcoreapi.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Services.Implementations
{
    public class UserServiceImplementation : IUserService
    {
        //Allows the use of context database on code [start]
        private MySQLContext _context;

        public UserServiceImplementation(MySQLContext context)
        {
            _context = context;
        }
        //[end]

        public User Create(User user)
        {
            try
            {
                _context.Add(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return user;
        }
        
        public User FindByMail(String mail)
        {
            return _context.Users.SingleOrDefault(user => user.Mail.Equals(mail));
           //throw new NotImplementedException();
        }
    }
}
