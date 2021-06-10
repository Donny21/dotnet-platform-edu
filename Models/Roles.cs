namespace Kalum21.Models
{
    public class Roles
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Roles()
        {
            
        }

        public Roles(int Id, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
        }
    }
}