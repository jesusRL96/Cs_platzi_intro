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

            var curso1 = new Curso() {
                Nombre = "101",
                Jornada = TiposJornada.Mañana
            };
            var curso2 = new Curso() {
                Nombre = "201",
                Jornada = TiposJornada.Tarde
            };
            var curso3 = new Curso() {
                Nombre = "301",
                Jornada = TiposJornada.Noche
            };
            Console.WriteLine("===========================");
            Console.WriteLine($"{curso1.Nombre} {curso1.Jornada} {curso1.UniqueId}");
            Console.WriteLine($"{curso2.Nombre} {curso2.Jornada} {curso2.UniqueId}");
            Console.WriteLine(curso3 + ", " + curso3.UniqueId);

        }
    }
}