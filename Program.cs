using System;
using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using CoreEscuela.Util;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.Beep(1500, 500, 3);
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            Printer.WriteTitle("Cursos Escuela");
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