namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre{
            get{
                return nombre;
            }
            set{
                nombre = value.ToUpper();
            }
        }
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        public Escuela(string nombreEntrada, int año) => (Nombre, AñoDeCreacion) = (nombreEntrada, año);

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela}, Año: {AñoDeCreacion}, \nPais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}