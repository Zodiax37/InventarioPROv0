using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoSoftware.Modelos
{
    internal class Venta
    {
        private double descuento;
        private Date Fecha;
        private List<Producto> ProductosVend;
	    private int Total;
        private Usuario User;
        public Preventa m_Preventa;
        public Factura m_Factura;

        public Venta()
        {

        }

        public Venta(double descuento, Date fecha, List<Producto> productosVend, int total, Usuario user, Preventa preventa, Factura factura)
        {
            this.descuento = descuento;
            Fecha = fecha;
            ProductosVend = productosVend;
            Total = total;
            User = user;
            m_Preventa = preventa;
            m_Factura = factura;
        }

        public void ActualizarInventario()
        {

        }

        public void CalcularTotal()
        {

        }

    }
}
