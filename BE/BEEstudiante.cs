using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class BEEstudiante : BEUsuario
    {
        public BEEstudiante(string pIdUsuario, string pNombre, string pApellido, string pCategoria, string pEmail, string pPassword)
            : base(pIdUsuario, pNombre, pApellido, pCategoria, pEmail, pPassword)
        {
        }

        public BEEstudiante(string pNombre, string pApellido, string pEmail, string pPassword) : base( pNombre, pApellido, pEmail, pPassword)
        {
        }
    }
}