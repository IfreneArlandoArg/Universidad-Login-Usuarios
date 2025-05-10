using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class BLLProfesor : UserRegistrationChecker, IAL
    {
        DALProfesor dalprofesor = new DALProfesor();
        public void Alta(BEUsuario pUsuario)
        {
            dalprofesor.Alta(pUsuario);
        }

        public override bool IsUserRegistered(string pEmail, string pPassword, out BEUsuario UserFound)
        {
            UserFound = null;

            bool returnValue = false;

            foreach (BEUsuario std in Listar())
            {

                if (std.Email == pEmail && std.Password == pPassword)
                {
                    UserFound = std;
                    returnValue = true; 
                }

            }

            return returnValue;
        }

        public List<BEUsuario> Listar()
        {
            return dalprofesor.Listar();
        }
    }
}
