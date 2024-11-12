using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Proveedor
    {
        public Proveedor()
        {
        }

        private string contacto {  get; set; }
        private int estado {  get; set; }
        private string nombre {  get; set; }

        public Proveedor(string contacto, int estado, string nombre)
        {
            this.contacto = contacto;
            this.estado = estado;
            this.nombre = nombre;
        }


        public void cambiarEstado()
        {
            this.estado = 0;
        }

        public void editarProveedor()
        {

        }


    }
}
