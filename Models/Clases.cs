namespace Kalum21.Models
{
    public class Clases
    {
        public string ClaseId { get; set; }
        public string Descripcion { get; set; }
        public int Ciclo { get; set; }
        public int CupoMaximo { get; set; }
        public int CupoMinimo { get; set; }
        public string CarreraId { get; set; }
        public string SalonId { get; set; }
        public string InstructorId { get; set; }
        public string HorarioId { get; set; }
        public virtual CarreraTecnica CarreraTecnica { get; set; }
        public virtual Salones Salones { get; set; }
        public virtual Instructores Instructores { get; set; }
        public virtual Horarios Horarios { get; set; }
    }
}