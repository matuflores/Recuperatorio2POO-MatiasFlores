using Recuperatorio2POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Datos
{
    public class RepositorioPersonas
    {
       private static RepositorioPersonas _instancia;
        private List<Persona> listaPersonas;

        public RepositorioPersonas()
        {
            listaPersonas = new List<Persona>();
        }



        public static RepositorioPersonas GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new RepositorioPersonas();
            }
            return _instancia;
        }

        public void Agregar(Persona persona)
        {
            listaPersonas.Add(persona);
        }

        public bool Existe(Persona persona)
        {
            return listaPersonas.Contains(persona);
        }
        public List<Persona> GetLista()
        {
            return listaPersonas;
        }

        public int GetCantidad()
        {
            return listaPersonas.Count();
        }
    }
}
