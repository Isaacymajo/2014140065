using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public class Empleado
    {
        public int id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Correo { get; set; }
        public decimal Sueldo { get; set; }

        public Empleado(int id, String nombre, String apellido, String correo, decimal sueldo)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Sueldo = sueldo;
        }
    }
}
