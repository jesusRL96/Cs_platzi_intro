using System;
using CoreEscuela.Entidades;
using static System.Console;

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
            escuela.Cursos = new Curso[] {
                new Curso("101", TiposJornada.Mañana),
                new Curso("201", TiposJornada.Tarde),
                new Curso("301", TiposJornada.Noche)
            };
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

        private static void ImprimirCursos(Curso[] arregloCursos)
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