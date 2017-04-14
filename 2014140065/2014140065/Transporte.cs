using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public class Transporte : Servicio
    {
        Bus bus;
        TipoViaje tipoViaje;
        Cliente cliente;
        LugarViaje destino;
        int id;
        decimal precio;

        public Transporte(int id, Bus bus, TipoViaje tipoViaje, Cliente cliente, LugarViaje destino, String fechaPartida, String fechaLlegada)
        {
            this.id = id;
            this.bus = bus;
            this.tipoViaje = tipoViaje;
            this.cliente = cliente;
            this.destino = destino;
            this.precio = destino.costoLugar + tipoViaje.costo;
            this.fechaLlegada = fechaLlegada;
            this.fechaPartida = fechaPartida;
        }
        public override decimal calcularServicio()
        {
            return precio;
        }
    }
}
