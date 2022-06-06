using System;
using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            WriteLine("===========================");
            WriteLine("Cursos Escuela");
            WriteLine("===========================");
            ImprimirCursos(engine.Escuela.Cursos);
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