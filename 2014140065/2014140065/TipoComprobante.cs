using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public class TipoComprobante
    {
        public String nombre { get; set; }
        public String descripcion { get; set; }

        public TipoComprobante(String nombre, String descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
