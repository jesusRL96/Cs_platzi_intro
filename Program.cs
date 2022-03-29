using System;
using CoreEscuela.Entidades;

namespace CsPlatziIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi School", 2019);
            escuela.Pais = "Mexico";
            escuela.Ciudad = "Mexico";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            Console.WriteLine(escuela);
        }
    }
}