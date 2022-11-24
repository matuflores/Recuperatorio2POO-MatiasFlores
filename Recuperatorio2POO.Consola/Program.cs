using Recuperatorio2POO.Datos;
using Recuperatorio2POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso curso1 = new Curso(2, Divisiones.A);//Creo el curso "2° A"

            //creo estudiantes 4 del mismo año y curso y dos distintos
            Estudiante estudiante1 = new Estudiante("Leo", "Messi", 12345678, 2, Divisiones.A);
            Estudiante estudiante2 = new Estudiante("Sergio", "Dennis", 15898745, 2, Divisiones.A);
            Estudiante estudiante3 = new Estudiante("Brad", "Pitt", 65874526, 2, Divisiones.A);
            Estudiante estudiante4 = new Estudiante("Justin", "Quiles", 125875365, 2, Divisiones.A);
            Estudiante estudiante5 = new Estudiante("Julio", "Cortazar", 12547852, 1, Divisiones.B);
            Estudiante estudiante6 = new Estudiante("Ernesto", "Guevara", 15879654, 1, Divisiones.B);

            //agrego dos alumnos
            curso1 += estudiante1;
            curso1 += estudiante2;

            //agregar alumno repetido
            Estudiante estudiante7 = new Estudiante("Sergio", "Dennis", 15898745, 2, Divisiones.A);
            if (estudiante2 == estudiante7)
            {
                Console.WriteLine("Alumno ya cursando!!");
            }
            else
            {
                curso1 += estudiante7;
            }

            Profesor profesor1 = new Profesor("Cimino", "Carlos", 15487536);
            Profesor profesor2 = new Profesor("Rivolta", "Ana", 14268469);

            curso1 += profesor1;
            curso1 += profesor2;

            //metodo explicito del equipo
            string datosCurso = curso1;
            Console.WriteLine(datosCurso);
            Console.ReadLine();


        }
    }
}
