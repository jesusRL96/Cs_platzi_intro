using System;


namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
        public Curso(string nombre, TiposJornada jornada)
        {
            UniqueId = Guid.NewGuid().ToString();
            Nombre = nombre;
            Jornada = jornada;
        }

        public override string ToString()
        {
            return $"{Nombre}, {Jornada}";
        }
    }
}