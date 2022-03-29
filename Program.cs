using System;
using CoreEscuela.Entidades;

namespace CsPlatziIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi School", 2019,TiposEscuela.Secundaria, ciudad:"Mexico");
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            Console.WriteLine(escuela);

            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso()
            {
                Nombre = "101",
                Jornada = TiposJornada.Mañana
            };
            var curso2 = new Curso()
            {
                Nombre = "201",
                Jornada = TiposJornada.Tarde
            };
            arregloCursos[1] = curso2;
            arregloCursos[2] = new Curso
                {
                    Nombre = "301",
                    Jornada = TiposJornada.Noche
                };
            Console.WriteLine("===========================");
            ImprimirCursos(arregloCursos);

        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                if (curso != null)
                {
                    Console.WriteLine($"{curso.UniqueId} {curso.Nombre} {curso.Jornada}");
                }
            }
        }
    }
}