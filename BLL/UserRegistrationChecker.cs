using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace BLL
{
    public abstract class UserRegistrationChecker
    {
        public abstract bool IsUserRegistered(string pEmail, string pPassword, out BEUsuario UserFound);
    }
}