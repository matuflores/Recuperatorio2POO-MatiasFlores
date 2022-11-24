using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Entidades
{
    public class Profesor : Persona
    {
        public DateTime fechaIngreso { get; }

        public Profesor(string Apellido, string Nombre, int DNI,DateTime FechaIngreso) : base(Apellido, Nombre, DNI)
        {
            fechaIngreso = FechaIngreso;
        }
        public Profesor(string Apellido, string Nombre,  int DNI):base(Apellido,Nombre,DNI)
        {
            fechaIngreso = DateTime.Now;
        }
        public override string ExponerDatos()
        {
            return $"{nombre} {apellido}, DNI: {documento}, Fecha Ingreso:{fechaIngreso}";
        }

        public override bool ValidarDocumento()
        {
            if (!(documento.ToString().Length == 8))
            {
                return false;
            }
            return true;
        }

        public int Antiguedad()//probar esto
        {
            int antiguedad = DateTime.Today.AddTicks(-fechaIngreso.Ticks).Year - 1;
            return antiguedad;
        }
    }
}
