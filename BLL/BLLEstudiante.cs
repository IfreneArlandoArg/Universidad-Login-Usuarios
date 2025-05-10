using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLEstudiante : UserRegistrationChecker, IAL
    {
        DALEstudiante dalEstudiante = new DALEstudiante();
        public void Alta(BEUsuario pUsuario)
        {
            dalEstudiante.Alta(pUsuario);
        }

        public override bool IsUserRegistered(string pEmail, string pPassword, out BEUsuario UserFound)
        {
            UserFound = null;

            bool returnValue = false;
            
            foreach(BEUsuario std in Listar()) 
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
            
            
            return dalEstudiante.Listar();

        }
    }
}