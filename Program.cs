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
        }
    }
}