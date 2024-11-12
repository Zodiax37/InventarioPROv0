using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Usuario
    {
        public Usuario()
        {
        }

        private string username {  get; set; }
        private string password { get; set; }
        private int rol {  get; set; }

        public Usuario(string username, string password, int rol)
        {
            this.username = username;
            this.password = password;
            this.rol = rol;
        }

        public void cmabiarPass()
        {

        }

        //LUEGO VER SI SE PUEDE EDITAR EL USERNAME

        public void cerrarSesion()
        {

        }

        public void iniciarSesion()
        {

        }
    }
}
