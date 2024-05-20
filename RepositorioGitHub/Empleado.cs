using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGitHub
{
    public abstract class Empleado: MiembroDeLaComunidad
    {
        public int Id { get; set; }
        public string Departamento { get; set; }

        public decimal? Sueldo { get; set; }

        public Empleado(string Nombre, int Edad, int Id, string Departamento, decimal? Sueldo)
            : base(Nombre, Edad)
        {
            this.Id = Id;
            this.Departamento = Departamento;
            this.Sueldo = Sueldo;
        }


    }            
}
