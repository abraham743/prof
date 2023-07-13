using PRecu.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRecu.Repositorio
{
    internal class DatosRepos
    {
        public static DatosRepos reposit;

        private static UsuarioD UsuarioP = new UsuarioD();

        private DatosRepos()
        {
           
        }
        public static DatosRepos getInstance()
        {
            if(reposit == null)
            {
                reposit = new DatosRepos();
            }
            return reposit;
        }
        public void SetUsuario(int id, string nombre)
        {
            UsuarioP.Id = id;
            UsuarioP.Nombre = nombre;
        }
        public UsuarioD GetUsuario()
        {
            return UsuarioP;
        }
    }
}
