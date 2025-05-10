using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class BEProfesor : BEUsuario
    {
        public BEProfesor(string pIdUsuario, string pNombre, string pApellido, string pCategoria, string pEmail, string pPassword) 
            : base(pIdUsuario, pNombre, pApellido, pCategoria, pEmail, pPassword)
        {
        }

        public BEProfesor( string pNombre, string pApellido, string pEmail, string pPassword) : base( pNombre, pApellido, pEmail, pPassword)
        {
        }

    }
}