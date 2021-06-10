using System.Collections.Generic;

namespace Kalum21.Models
{
    public class Salones
    {
        public string SalonId { get; set; }
        public int Capacidad { get; set; }
        public string Descripcion { get; set; }
        public string NombreSalon { get; set; }
        public virtual List<Clases> Clases {get; set;}
    }
}