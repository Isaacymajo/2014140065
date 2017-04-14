using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public class Administrativo : Empleado
    {
        public String area { get; set; }
        public String horaIngreso { get; set; }
        public String horaSalida { get; set; }

        public Administrativo(int id, String nombre, String apellido, String correo, decimal sueldo, String area, String horaIngreso, String horaSalida)
            : base(id, nombre, apellido, correo, sueldo)
        {
            this.area = area;
            this.horaIngreso = horaIngreso;
            this.horaSalida = horaSalida;
        }
    }
}
