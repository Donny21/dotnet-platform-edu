using System.Collections.Generic;

namespace Kalum21.Models
{
    public class CarreraTecnica
    {
        public string CarreraId { get; set; }
        public string Nombre { get; set; }
        public virtual List<Clases> Clases { get; set; }
    }
}