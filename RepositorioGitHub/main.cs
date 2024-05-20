using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGitHub
{
    public class main
    {
        static void Main(string[] args) {

            MiembroDeLaComunidad miembroDeLaComunidad = new Estudiante("Miguel", 25, 20236666, "Multimedia");
            miembroDeLaComunidad.InformacionCiudadano();

            MiembroDeLaComunidad exAlumno = new ExAlumno("Jose", 25, 20236895, "Software",new(2023,2,2));
            exAlumno.InformacionCiudadano();

            Empleado administrativo = new Administrativo("Mario", 35, 1504, "Contabilidad", "Gerente", 40000);
            administrativo.InformacionCiudadano();

            Docente maestro = new Maestro("Alejandro", 28, 1824, "Departamento de Artes", "Arquitectura Moderna", 15000, "Universitario");
            maestro.InformacionCiudadano();

            Docente administrador = new Administrador("Manuel", 55, 2025, "Software", "Programacion", 50000, "Departamente de Gestion de Riesgos");
            administrador.InformacionCiudadano();

        }
    }
}
