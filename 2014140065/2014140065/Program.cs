using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            
            TipoTripulacion azafata = new TipoTripulacion("Azafata", "asistente de viaje encargada de la atencion del cliente dentro del bus.");
            TipoTripulacion chofer = new TipoTripulacion("Conductor", "encargado de manejar el bus y llevar a los pasajeros sanos y salvos a su destino.");

            
            TipoPago efectivo = new TipoPago("efectivo", "Pagar con dinero al contado");
            TipoPago tarjeta = new TipoPago("tarjeta", "Pagar con tarjeta de credito o débito");

            
            TipoComprobante boleta = new TipoComprobante("boleta", "Comprobante que no se aplica IGV.");
            TipoComprobante factura = new TipoComprobante("factura", "Comprobante que se le aplica todos los impuestos que le correspondan.");

            
            TipoLugar nacional = new TipoLugar("nacional", "Dentro del pais", 20);
            TipoLugar internacional = new TipoLugar("internacional", "Fuera del pais", 30);

            
            TipoViaje normal = new TipoViaje("normal", "Servicio de Bus Normal");
            TipoViaje vip = new TipoViaje("vip", "Servicio de Bus Cama");

            
            LugarViaje icaDestino = new LugarViaje(nacional, "Ica", 70);
            LugarViaje ArDestino = new LugarViaje(nacional, "Arequipa", 75);
            LugarViaje brazilDestino1 = new LugarViaje(internacional, "Brazil", 40);

            
            Administrativo admin1 = new Administrativo(1, "Daniel", "Revilla", "isaac_reviila@hotmail.com", 1000, "ventas", "08:00", "15:00");
            Administrativo admin2 = new Administrativo(2, "Alejandro", "Paredes", "Aparedes@gmail.com", 1000, "ventas", "08:00", "16:00");
            Tripulacion tripul1 = new Tripulacion(1, "Ana", "Barreno", "Abarreno@gmail.com", 1200, azafata, 5);
            Tripulacion tripul2 = new Tripulacion(2, "Maria", "Quispe", "Mquispe@gmail.com", 1100, azafata, 4);
            Tripulacion tripul3 = new Tripulacion(3, "Miguel", "Castro", "Mcastro@gmail.com", 1500, chofer, 6);
            Tripulacion tripul4 = new Tripulacion(4, "Nicolas", "Acero", "Nacero@gmail.com", 1500, chofer, 6);

            
            Bus bus1 = new Bus("FOI-321", "Wolsvagen", "Blanco", 34500);
            bus1.AgregarTripulante(tripul1);
            bus1.AgregarTripulante(tripul3);

            
            Cliente cliente1 = new Cliente(25638855, "Diego", "Cabrera", 19, 'm', "Dcabrera@gmail.com", 976483922);
            Cliente cliente2 = new Cliente(15487887, "Maria", "Salamanca", 21, 'f', "Msalamanca@gmail.com", 997381903);
            Cliente cliente3 = new Cliente(14747496, "Paz", "Barrantes", 18, 'f', "Pbarrantes@gmail.com", 907281992);
            Cliente cliente4 = new Cliente(14587444, "Antonio", "Rojas", 15, 'm', "Arojas@gmail.com", 987192577);
            Cliente cliente5 = new Cliente(14855499, "Seyla", "Sarmiento", 20, 'f', "Ssarmiento@gmail.com", 996482711);

            // Ventas (3 Pasajes y 2 Encomiendas)
            List<Venta> listaVentas = new List<Venta>();
            Venta pasaje1 = new Venta(1, admin1, cliente1, boleta, new Transporte(1, bus1, normal, cliente1, icaDestino, "22/04/17", "23/04/17"), efectivo, "20/04/17", normal);
            Venta pasaje2 = new Venta(2, admin1, cliente2, boleta, new Transporte(2, bus1, normal, cliente2, ArDestino, "22/04/17", "23/04/17"), efectivo, "21/04/17",vip);
            Venta pasaje3 = new Venta(3, admin1, cliente3, boleta, new Transporte(3, bus1, normal, cliente3, icaDestino, "22/04/17", "23/04/17"), efectivo, "21/04/17",vip);
            Venta encomienda1 = new Venta(4, admin2, cliente4, factura, new Encomienda(1, icaDestino, bus1, "Botellon de 20Lt de Agua", "22/04/17", "23/04/17"), tarjeta, "20/04/17", normal);
            Venta encomienda2 = new Venta(5, admin2, cliente5, factura, new Encomienda(2, ArDestino, bus1, "Televisor 60´", "22/04/17", "23/04/17"), tarjeta, "21/04/17",vip);

            listaVentas.Add(pasaje1);
            listaVentas.Add(pasaje2);
            listaVentas.Add(pasaje3);
            listaVentas.Add(encomienda1);
            listaVentas.Add(encomienda2);

            foreach (Venta venta in listaVentas)
            {
                if(venta.id <= 3)
                {
                    Console.WriteLine("Pasaje " + venta.id);
                    venta.info();
                    Console.WriteLine("------------------------");
                }
                else
                {
                    Console.WriteLine("Encomienda " + venta.id);
                    venta.info();
                    Console.WriteLine("------------------------");
                }
                

            }
        }
    }
}
