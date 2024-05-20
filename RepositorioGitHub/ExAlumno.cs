using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGitHub
{
    public class ExAlumno: MiembroDeLaComunidad
    {
        public int Matricula { get; set; }
        public string Carrera { get; set; }

        public DateOnly FechaSalida;

        public ExAlumno(string Nombre, int Edad, int Matricula, string Carrera, DateOnly FechaSalida) 
            : base(Nombre, Edad)
        {
            this.Matricula = Matricula;
            this.Carrera = Carrera;
            this.FechaSalida = FechaSalida;
        }

        public override void InformacionCiudadano()
        {

            Console.WriteLine("\n\n**************** EX ESTUDIANTE ****************");
            Console.WriteLine($"Estudiante: {Nombre}, Carrera: {Carrera}, Matricula: {Matricula}, Edad: {Edad}, Fecha de salida: {FechaSalida}");
            Console.WriteLine("********************************************\n\n");

        }
    }
}
