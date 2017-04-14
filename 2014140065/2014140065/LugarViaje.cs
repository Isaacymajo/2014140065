using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public class LugarViaje
    {
        TipoLugar tipoLugar;
        String nombreLugar;

        public LugarViaje(TipoLugar tipoLugar, String nombreLugar, decimal costoBase)
        {
            this.nombreLugar = nombreLugar;
            this.tipoLugar = tipoLugar;
            this.costoLugar = costoBase + tipoLugar.costoTipoLugar;
        }
        public decimal costoLugar { get; set; }
    }
}
