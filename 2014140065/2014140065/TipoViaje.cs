using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public class TipoViaje
    {
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public decimal costo { get; set; }

        public TipoViaje(String nombre, String descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            if (nombre.Equals("normal"))
            {
                this.costo = 15;
            }
            else
            {
                this.costo = 20;
            }
        }
    }
}
