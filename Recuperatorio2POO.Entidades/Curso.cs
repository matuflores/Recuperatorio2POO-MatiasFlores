using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Entidades
{
    public class Curso
    {
        public List<Estudiante> estudiantes;
        public short anio;
        public Divisiones division;
        public List<Profesor> profesores;

        private Curso()
        {
            estudiantes = new List<Estudiante>();
            profesores = new List<Profesor>();
        }

        public Curso(short Anio, Divisiones Division):this()
        {
            this.anio = Anio;
            division = Division;

        }

        public static bool operator ==(Curso curso1, Estudiante estudiante1)
        {
            return curso1.estudiantes.Contains(estudiante1) ;
        }
        public static bool operator !=(Curso curso1, Estudiante estudiante1)
        {
            return !curso1.estudiantes.Contains(estudiante1);
        }
        public static bool operator ==(Curso curso1, Profesor profesor1)
        {
            return curso1.profesores.Contains(profesor1);
        }
        
        public static bool operator !=(Curso curso1, Profesor profesor1)
        {
            return !curso1.profesores.Contains(profesor1);
        }

        public static Curso operator +(Curso curso1, Profesor profesor1)
        {
            if (curso1 != profesor1)
            {
                curso1.profesores.Add(profesor1);
                return curso1;
            }
            return curso1;
        }
        public static Curso operator +(Curso curso1, Estudiante estudiante1)
        {
            if (curso1!=estudiante1)
            {
                if (estudiante1.AnioDivision()==curso1.AnioDivision())
                {
                    curso1.estudiantes.Add(estudiante1);
                    return curso1;
                }
            }
            return curso1;
        }

        public string AnioDivision()
        {
            return $"{this.anio}°{this.division}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static implicit operator string(Curso curso1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(curso1.AnioDivision());
            sb.AppendLine("Alumnos: ");
            sb.AppendLine(curso1.ListaAlumnos());
            sb.AppendLine("Profesores: ");
            sb.AppendLine(curso1.ListaProfesores());
            return sb.ToString();

        }

        private string ListaProfesores()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Profesor profesor in profesores)
            {
                sb.AppendLine(profesor.ExponerDatos());
            }
            return sb.ToString();
        }

        public string ListaAlumnos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Estudiante estudiante in estudiantes)
            {
                sb.AppendLine(estudiante.ExponerDatos());
            }
            return sb.ToString();
        }
    }
}
