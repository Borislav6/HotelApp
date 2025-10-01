using System.ComponentModel.DataAnnotations;

namespace HotelWebApp.Data.Entities
{
    public class Client
    {
        public Client()
        { 
        this.Reservations = new HashSet<Reservation>();
           
        }
        public int id { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string Egn { get; set; } = null!;
        [Required]
       
        public string FirstName { get; set; } = null!;
        [Required]

        public string LastName { get; set; }=null!;
        [Required] 
        public string City { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        

        public ICollection<Reservation> Reservations { get; set;}
    }
}
