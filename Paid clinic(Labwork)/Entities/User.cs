
namespace Entities
{
    public abstract class User
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}