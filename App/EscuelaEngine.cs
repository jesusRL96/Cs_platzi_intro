using CoreEscuela.Entidades;
using System.Linq;

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
            Escuela = new Escuela("Platzi School", 2019, TiposEscuela.Secundaria, ciudad: "Mexico");
            Escuela.TipoEscuela = TiposEscuela.Secundaria;
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluacion
                            {
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno,
                                Asignatura = asignatura
                            };
                        }
                    }
                }
            }
        }

        private List<Alumno> GenerarAlumnos(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            return listaAlumnos.OrderBy(al => al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre="Matematicas"},
                    new Asignatura{Nombre="Educacion Fisica"},
                    new Asignatura{Nombre="Castellano"},
                    new Asignatura{Nombre="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private void CargarCursos()
        {
            var listaCursos = new List<Curso>(){
                new Curso("101", TiposJornada.Mañana),
                new Curso("201", TiposJornada.Tarde),
                new Curso("301", TiposJornada.Noche)
            };

            Escuela.Cursos = listaCursos;
            Escuela.Cursos.Add(new Curso("401", TiposJornada.Mañana));
            Escuela.Cursos.Add(new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde });

            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantidad = rnd.Next(20,50);
                curso.Alumnos = GenerarAlumnos(cantidad);
                Console.WriteLine(curso.Alumnos.Count);
            }
        }
    }
}