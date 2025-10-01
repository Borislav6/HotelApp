using System.ComponentModel.DataAnnotations;

namespace HotelWebApp.Data.Entities
{
    public class Room
    {
        public Room() 
        {
            this.Reservations = new HashSet<Reservation>();
        }
        public int ID { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        
        public string Picture { get; set; } = null!;
        [Required]
        public string Type { get; set; } = null!;
        [Required]
        public int Beds { get; set; }

        [Required]
        public string Extra { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
