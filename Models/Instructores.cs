using System.Collections.Generic;

namespace Kalum21.Models
{
    public class Instructores
    {
        public string InstructorId { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Estatus { get; set; }
        public string Foto { get; set; }
        public string Comentario { get; set; }
        public virtual List<Clases> Clases { get; set; }
    }
}