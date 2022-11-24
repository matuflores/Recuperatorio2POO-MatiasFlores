using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Entidades
{
    public class Estudiante : Persona
    {
        public short anio { get; }
        public Divisiones division { get; }

        public Estudiante(string Nombre, string Apellido, int DNI, short Anio, Divisiones Division) : base(Apellido, Nombre, DNI)
        {
            this.anio = Anio;
            division = Division;
        }
        public string AnioDivision()
        {
            return $"{this.anio}°{this.division}";
        }
        public override string ExponerDatos()
        {
            return $"{this.nombre} {this.apellido}, DNI:{this.documento}, {AnioDivision()}";
        }

        public override bool ValidarDocumento()
        {
            if (!(documento.ToString().Length>=8))
            {
                return false;
            }
            return true;
        }
        
    }
}
