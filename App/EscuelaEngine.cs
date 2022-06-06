using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void Inicializar()
        {
            var Escuela = new Escuela("Platzi School", 2019, TiposEscuela.Secundaria, ciudad: "Mexico");
            Escuela.TipoEscuela = TiposEscuela.Secundaria;
            var listaCursos = new List<Curso>(){
                new Curso("101", TiposJornada.Mañana),
                new Curso("201", TiposJornada.Tarde),
                new Curso("301", TiposJornada.Noche)
            };


            Escuela.Cursos = listaCursos;
            Escuela.Cursos.Add(new Curso("401", TiposJornada.Mañana));
            Escuela.Cursos.Add(new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde });
            this.Escuela = Escuela;
            // var otraColeccion = new List<Curso>(){
            //     new Curso("102", TiposJornada.Mañana),
            //     new Curso("202", TiposJornada.Tarde),
            //     new Curso("302", TiposJornada.Noche)
            // };
            // otraColeccion.Clear(); // Limpia la coleccion
            // Curso tmp = new Curso("601", TiposJornada.Mañana);
            // Escuela.Cursos.Add(tmp);
            // Escuela.Cursos.Remove(tmp); // Elimina el curso
            // Escuela.Cursos.RemoveAt(0); // Elimina el curso en la posicion 0
            // Escuela.Cursos.RemoveAll(delegate(Curso curso) { return curso.Nombre == "301";}); // (delegate) Elimina todos los cursos que coincidan con el nombre
            // Escuela.Cursos.RemoveAll(curso => curso.Nombre == "301"); // Elimina todos los cursos que coincidan con el nombre
            // Escuela.Cursos.AddRange(otraColeccion);
        }

    }
}