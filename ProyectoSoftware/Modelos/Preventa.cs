using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Preventa
    {
        public Preventa()
        {
        }

        private int cantidad {  get; set; }
        private int estado { get; set; }
        private  DateTime Fecha { get; set; }
        private List<Producto> productosSeleccionados { get; set; }
        private double SubTotal { get; set; }

        public Preventa(int cantidad, int estado, DateTime fecha, List<Producto> productosSeleccionados, double subTotal)
        {
            this.cantidad = cantidad;
            this.estado = estado;
            Fecha = fecha;
            this.productosSeleccionados = productosSeleccionados;
            SubTotal = subTotal;
        }


        public void agregarProducto(Producto producto)
        {
        }

        public void CalcularSubtotal(List<Producto> prds /*No se si asi esta bien, luego buscar*/)
        {

        }

        public void deshacerPreventa()
        {
            
        }

        public void eliminarProducto(Producto producto)
        {

        }
    }
}
