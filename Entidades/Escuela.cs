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
        public Escuela(string nombreEntrada, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, AñoDeCreacion) = (nombreEntrada, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela}, Año: {AñoDeCreacion}, {System.Environment.NewLine}Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}