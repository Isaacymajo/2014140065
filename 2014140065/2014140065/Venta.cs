using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public class Venta
    {
        Administrativo administrativo;
        Cliente cliente;
        Servicio servicio;
        TipoPago tipoPago;
        TipoComprobante tipoComprobante;
        TipoViaje serv;
        

        public Venta(int id, Administrativo administratativo, Cliente cliente, TipoComprobante tipoComprobante, Servicio servicio, TipoPago tipoPago, String fechaVenta, TipoViaje serv)
        {
            this.id = id;
            this.administrativo = administratativo;
            this.cliente = cliente;
            this.servicio = servicio;
            this.tipoPago = tipoPago;
            this.tipoComprobante = tipoComprobante;
            this.costo = servicio.calcularServicio();
            this.FechaVenta = fechaVenta;
            this.serv = serv;
        }

        public int id { get; set; }
        public decimal costo { get; set; }
        public String FechaVenta { get; set; }

        public void info()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Servicio : " + this.servicio);
            Console.WriteLine("Tipo de Viaje: " + this.serv.nombre);
            Console.WriteLine("Nombre Cliente: " + this.cliente.nombres + " " + this.cliente.apellidos);
            Console.WriteLine("Tipo de comprobante: " + this.tipoComprobante.nombre);
            Console.WriteLine("Precio: " + this.costo);
            Console.WriteLine("Tipo de Pago: " + this.tipoPago.nombre);
            Console.WriteLine("Fecha Venta: " + this.FechaVenta);
            Console.WriteLine("Fecha Partida: " + this.servicio.fechaPartida);
            Console.WriteLine("Fecha Llegada: " + this.servicio.fechaLlegada);
        }


    }
}
