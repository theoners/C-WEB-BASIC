using System;
using System.Collections.Generic;
using System.Text;
using SIS.HTTP;
using SIS.MvcFramework;

namespace Suls.Controllers
{
    public class UsersController:Controller
    {
        public HttpResponse Login()
        {
           
            return this.View();
        }

        public HttpResponse Register()
        {
            return this.View();
        }
    }
}
