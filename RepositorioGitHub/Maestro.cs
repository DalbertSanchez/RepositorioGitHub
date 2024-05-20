using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGitHub
{
    public class Maestro: Docente
    {
        public string NivelAcademico { get; set; }

        public Maestro(string Nombre, int Edad, int Id, string Departamento, string Materia, decimal? Sueldo, 
                       string NivelAcademico): base(Nombre, Edad, Id, Departamento,Materia, Sueldo)
        {
            this.NivelAcademico = NivelAcademico;

        }

        public override void InformacionCiudadano()
        {
            Console.WriteLine("\n\n**************** MAESTRO ****************");

            Console.WriteLine($"Id: {Id}, Nombre: {Nombre}, Edad: {Edad}, Departamento: {Departamento}, Materia: {Materia}, Nivel Academico: {NivelAcademico}, Sueldo: {Sueldo}");

            Console.WriteLine("********************************************\n\n");

        }
    }
}
