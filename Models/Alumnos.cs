namespace Kalum21.Models
{
    public class Alumnos
    {
        public string Carnet { get; set; }
        public string NoExpediente { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }

        public Alumnos()
        {
            
        }

        public Alumnos(string Carnet, string NoExpediente, string Apellidos, string Nombres, string Email)
        {
            this.Carnet = Carnet;
            this.NoExpediente = NoExpediente;
            this.Apellidos = Apellidos;
            this.Nombres = Nombres;
            this.Email = Email;
        }
    }
}