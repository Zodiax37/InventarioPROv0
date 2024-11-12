using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Factura
    {
        private DateTime FechaHora { get; set; }
        private double totalFactura { get; set; }
        private Venta venta { get; set; }

        public Factura()
        {
        }

        public Factura(DateTime fechaHora, double totalFactura, Venta venta)
        {
            FechaHora = fechaHora;
            this.totalFactura = totalFactura;
            this.venta = venta;
        }

        public void generarFacturaPDF()
        {

        }

        public void imprimirFactura()
        {

        }
    }
}
