using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public class Encomienda :Servicio
    {
        int id;
        LugarViaje destino;
        Bus bus;
        String descripcion;
        decimal precio;

        public Encomienda(int id, LugarViaje destino, Bus bus, String descripcion, String fechaPartida, String fechaLlegada)
        {
            this.id = id;
            this.destino = destino;
            this.bus = bus;
            this.descripcion = descripcion;
            this.precio = destino.costoLugar;
            this.fechaLlegada = fechaLlegada;
            this.fechaPartida = fechaPartida;
        }

        public override decimal calcularServicio()
        {
            return precio;
        }
    }
}
