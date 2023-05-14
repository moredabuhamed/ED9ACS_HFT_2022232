using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ED9ACS_HFT_2022232_Models
{
     public class ReservationsServices
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey(nameof(Reservations))]
        public int? ReservationId { get; set; }


        [NotMapped]
        [JsonIgnore]
        public virtual Reservations Reservations { get; set; }


        [ForeignKey(nameof(Services))]
        public int? ServiceId { get; set; }



        [NotMapped]
        [JsonIgnore]
        public virtual Services Services { get; set; }
        public override string ToString()
        {
            return $"{this.Id,3} | {this.ReservationId,5}\t {this.ServiceId,10}";
        }
    }
}