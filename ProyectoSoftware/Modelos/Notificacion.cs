using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Notificacion
    {
        

        private DateTime Fecha { get; set; }
        private int idProducto { get; set; }
        private int idAdmin {  get; set; }
        public Notificacion()
        {
        }

        public Notificacion(DateTime fecha, int idProducto, int idAdmin)
        {
            Fecha = fecha;
            this.idProducto = idProducto;
            this.idAdmin = idAdmin;
        }

        public void EnviarNotificacion()
        {

        }
    }
}
