using Recuperatorio2POO.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Datos
{
    public static class Serializador
    {
        public static void GuardarJsonEstudiantes(string archivoJsonE, List<Estudiante> estudiante)
        {
            using (var escritor = new StreamWriter(archivoJsonE))
            {
                var stringJsonEstudiantes = JsonSerializer.Serialize(estudiante);
                escritor.WriteLine(stringJsonEstudiantes);
            }
        }
        public static void GuardarJsonProfesores(string archivoJsonP, List<Profesor> profesor)
        {
            using (var escritor = new StreamWriter(archivoJsonP))
            {
                var stringJsonProfesores = JsonSerializer.Serialize(profesor);
                escritor.WriteLine(stringJsonProfesores);
            }
        }



    }

}
