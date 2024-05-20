using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGitHub
{
    public class Administrativo: Empleado
    {
        public string Cargo {get; set; }

        public Administrativo(string Nombre, int Edad, int Id, string Departamento, string Cargo, decimal? Sueldo ) 
        :base(Nombre,Edad,Id,Departamento, Sueldo)
        
        {
          this.Cargo = Cargo;

        }

        public override void InformacionCiudadano()
        {
            Console.WriteLine("\n\n**************** ADMINISTRATIVO ****************");

            Console.WriteLine($"Id: {Id}, Docente: {Nombre}, Departamento: {Departamento}, Cargo: {Cargo}, Edad: {Edad}");

            Console.WriteLine("********************************************\n\n");

        }
    }
}
