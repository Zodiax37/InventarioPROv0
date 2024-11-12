using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Empleado : Persona
    {
        private string AreaDeTrabajo{ get; set; }
        private string cargo {  get; set; }

        private int Estado {  get; set; }

        public Empleado()
        {
        }

        public Empleado(string areaDeTrabajo, string cargo, int estado)
        {
            AreaDeTrabajo = areaDeTrabajo;
            this.cargo = cargo;
            Estado = estado;
        }

        public void CambiarEstado()
        {
            this.Estado = 0;
        }

        public void Modificar(string areaNueva, string cargoNuevo)
        {
            this.AreaDeTrabajo = areaNueva;
            this.cargo = cargoNuevo;
        }


    }
}
