using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Inventario
    {
        //VER SI LO DEJO COMO IDPROD O DE UNA COMO PRODUCTO
        private int cantidad { get; set ; }
        private int idProducto {  get; set ; }
        private int umbral_baja_Existencia { get; set ; }

        public Inventario()
        {
        }

        public Inventario(int cantidad, int idProducto, int umbral_baja_Existencia)
        {
            this.cantidad = cantidad;
            this.idProducto = idProducto;
            this.umbral_baja_Existencia = umbral_baja_Existencia;
        }


        public void actualizarInventario()
        {

        }

        //TALVEZ QUE RETORNE TIPO PRODUCTO
        public void verificarStock(int idProducto)
        {

        }



    }
}
