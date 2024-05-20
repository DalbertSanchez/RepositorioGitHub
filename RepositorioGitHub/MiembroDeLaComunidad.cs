using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGitHub
{
    public abstract class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public MiembroDeLaComunidad(string Nombre, int Edad) { 
        
            this.Nombre = Nombre;
            this.Edad = Edad;
        }

        public abstract void InformacionCiudadano();
     
    }
}
