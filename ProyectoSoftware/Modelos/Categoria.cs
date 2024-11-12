using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Categoria
    {
        

        private string Nombre {  get; set; }
        private string Descripcion { get; set; }

        public Categoria()
        {
        }

        public Categoria(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public void EditarCategoria(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        //No se si poner eliminar categoria
    }
}
