using System;

namespace CsPlatziIntro
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;

        public string ceo;

        public void Timbrar()
        {
            // TODO
            Console.Beep(1000, 1000);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var miEscuela = new Escuela();
            miEscuela.nombre = "platzi";
            miEscuela.direccion = "calle falsa 123";
            miEscuela.añoFundacion = 2019;
            Console.WriteLine($"Nombre: {miEscuela.nombre}, Timbrar");
            miEscuela.Timbrar();
        }
    }
}