using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEUsuario
    {
         

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Categoria { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public BEUsuario() { }

        public BEUsuario(string pIdUsuario, string pNombre, string pApellido, string pCategoria, string pEmail, string pPassword) 
        {
            IdUsuario = int.Parse(pIdUsuario);
            Nombre = pNombre;
            Apellido = pApellido;
            Categoria = pCategoria;
            Email = pEmail;
            Password = pPassword;
        
        }



        public BEUsuario(string pNombre, string pApellido, string pEmail, string pPassword)
        {
         
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Password = pPassword;

        }

    }
}
