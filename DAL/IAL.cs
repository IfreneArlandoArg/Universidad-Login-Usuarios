using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace DAL
{
    public interface IAL
    {
        void Alta(BEUsuario pUsuario);
        List<BEUsuario> Listar();
        
    }
}