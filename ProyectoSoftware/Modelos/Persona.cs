using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware.Modelos
{
    internal class Persona
    {
        public Persona()
        {
        }

        private string Cedula { get; set; }
        private string Correo { get; set; }
        private string Direccion { get; set; }
        private int edad { get; set; }
        private DateTime FechaNac { get; set; }
        private string PrimerNombre {get; set;}
        private string SegundoNombre{get; set;}
        private string PrimerApellido{get; set;}
        private string SegundoApellido{ get; set; }
        private string Telefono {  get; set; }

        public Persona(string cedula, string correo, string direccion, int edad, DateTime fechaNac, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono)
        {
            Cedula = cedula;
            Correo = correo;
            Direccion = direccion;
            this.edad = edad;
            FechaNac = fechaNac;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Telefono = telefono;
        }
    }
}
