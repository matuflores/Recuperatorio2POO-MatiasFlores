using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Entidades
{
    public abstract class Persona
    {
        public string apellido { get; }
        public string nombre { get;  }
        public int documento { get;  }

        public abstract string ExponerDatos();

        public abstract bool ValidarDocumento();

        public Persona(string Apellido,string Nombre, int DNI)
        {
            this.apellido = Apellido;
            this.nombre = Nombre;
            this.documento = DNI;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Persona))
            {
                return false;
            }
            return this.documento == ((Persona)obj).documento;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Persona persona1, Persona persona2)
        {
            return persona1.documento == persona2.documento;
        }

        public static bool operator !=(Persona persona1, Persona persona2)
        {
            return !(persona1.documento == persona2.documento);
        }

        
    }
}
