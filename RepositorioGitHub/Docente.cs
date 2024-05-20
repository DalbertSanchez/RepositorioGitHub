using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGitHub
{
    public abstract class Docente: Empleado
    {
        public string Materia { get; set; }

        public Docente(string Nombre, int Edad, int Id, string Departamento, string Materia,decimal? Sueldo)
            : base(Nombre,Edad,Id,Departamento,Sueldo)
        {
            this.Materia = Materia;
        }

        
    }
}
