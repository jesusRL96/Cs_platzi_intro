using System;
using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;

namespace CsPlatziIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi School", 2019,TiposEscuela.Secundaria, ciudad:"Mexico");
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            Console.WriteLine(escuela);

            // Curso[] arregloCursos = {
            //     new Curso("101", TiposJornada.Mañana),
            //     new Curso("201", TiposJornada.Tarde),
            //     new Curso("301", TiposJornada.Noche)
            // };
            // escuela.Cursos = arregloCursos;
            var listaCursos = new List<Curso>(){
                new Curso("101", TiposJornada.Mañana),
                new Curso("201", TiposJornada.Tarde),
                new Curso("301", TiposJornada.Noche)
            };


            escuela.Cursos = listaCursos;
            escuela.Cursos.Add(new Curso("401", TiposJornada.Mañana));
            escuela.Cursos.Add(new Curso(){Nombre = "501", Jornada = TiposJornada.Tarde});
            var otraColeccion = new List<Curso>(){
                new Curso("102", TiposJornada.Mañana),
                new Curso("202", TiposJornada.Tarde),
                new Curso("302", TiposJornada.Noche)
            };
            otraColeccion.Clear(); // Limpia la coleccion
            Curso tmp = new Curso("601", TiposJornada.Mañana);
            escuela.Cursos.Add(tmp);
            ImprimirCursos(escuela.Cursos);
            escuela.Cursos.Remove(tmp); // Elimina el curso
            // escuela.Cursos.RemoveAt(0); // Elimina el curso en la posicion 0
            escuela.Cursos.RemoveAll(curso => curso.Nombre == "301"); // Elimina todos los cursos que coincidan con el nombre
            escuela.Cursos.AddRange(otraColeccion);

            WriteLine("===========================");
            WriteLine("Cursos Escuela");
            WriteLine("===========================");
            // escuela.Cursos = null;
            if (escuela?.Cursos != null)
            {
                ImprimirCursos(escuela.Cursos);
            }
            else
            {
                WriteLine("No hay cursos");
            }

        }

        private static void ImprimirCursos(List<Curso> arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                if (curso != null)
                {
                    WriteLine($"{curso.UniqueId} {curso.Nombre} {curso.Jornada}");
                }
            }
        }
    }
}