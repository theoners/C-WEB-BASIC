using System;
using System.Collections.Generic;
using System.Text;

namespace Suls.Services
{
   public class UserService : IUserService
    {
        public string GetUserId(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(string username, string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool UsernameExists(string username)
        {
            throw new NotImplementedException();
        }

        public bool EmailExists(string email)
        {
            throw new NotImplementedException();
        }

        public string GetUsername(string id)
        {
            throw new NotImplementedException();
        }
    }
}
