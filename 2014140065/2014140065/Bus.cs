using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140065
{
    public class Bus
    {
        List<Tripulacion> listaTripulacion;
        public string NroPlaca { get; set; }
        public String Modelo { get; set; }
        public String Color { get; set; }
        public decimal Kilometraje { get; set; }

        public Bus(String nroPlaca, String modelo, String color, decimal kilometraje)
        {
            this.NroPlaca = nroPlaca;
            this.Modelo = modelo;
            this.Color = color;
            this.Kilometraje = kilometraje;
            this.listaTripulacion = new List<Tripulacion>();
        }

        public Encomienda encomienda { get; set; }

        public void AgregarTripulante(Tripulacion tripulacion)
        {
            tripulacion.estado = false;
            listaTripulacion.Add(tripulacion);
        }

        public void RemoverTripulante(Tripulacion tripulacion)
        {
            tripulacion.estado = true;
            listaTripulacion.Remove(tripulacion);
        }
    }
}
