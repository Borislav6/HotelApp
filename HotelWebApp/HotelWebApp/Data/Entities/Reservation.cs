using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWebApp.Data.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        [ForeignKey("Client")]
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        [ForeignKey("Room")]
        [Required]
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [Required]
        public DateTime DateArrival { get; set; }
        [Required]
        public DateTime DateLeave { get; set; }
        
        public decimal Discount { get; set; }
    }
}
