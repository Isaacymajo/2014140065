using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public abstract class Servicio
    {
        public String fechaPartida { get; set; }
        public String fechaLlegada { get; set; }
        public abstract decimal calcularServicio();
    }
}
