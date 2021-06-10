using System;
using System.Collections.Generic;

namespace Kalum21.Models
{
    public class Horarios
    {
        public string HorarioId { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFinal { get; set; }
        public virtual List<Clases> Clases { get; set; }
    }
}