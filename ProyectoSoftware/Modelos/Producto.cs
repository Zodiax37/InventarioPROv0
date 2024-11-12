using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Producto
    {
        public Producto()
        {
        }

        private int idCategoria { get; set; }
        private double costo { get; set; }
        private int estado { get; set; }
        private Proveedor proveedor { get; set; }
        private string nombre { get; set; }
        public double PrecioVenta { get; set; }

        public Producto(int idCategoria, double costo, int estado, Proveedor proveedor, string nombre, double precioVenta)
        {
            this.idCategoria = idCategoria;
            this.costo = costo;
            this.estado = estado;
            this.proveedor = proveedor;
            this.nombre = nombre;
            PrecioVenta = precioVenta;
        }

        public void ActualziarProducto()
        {

        }

        public void calcularPrecioVenta()
        {

        }

        public void consulatarProducto()
        {

        }

        public void listarProductos()
        {

        }

        
    }
}
