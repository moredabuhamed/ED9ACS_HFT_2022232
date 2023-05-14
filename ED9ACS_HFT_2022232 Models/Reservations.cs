using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System;

namespace ED9ACS_HFT_2022232_Models
{
    [Table("reservations")]

    public class Reservations
    {
        public Reservations()
        {
            this.ConnectorReservationsServices = new HashSet<ReservationsServices>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        public DateTime DateTime { get; set; }


        [NotMapped]
        [JsonIgnore]
        public virtual Fans Fan { get; set; }


        [ForeignKey(nameof(Fan))]
        public int? FanId { get; set; }



        [NotMapped]
        [JsonIgnore]
        public virtual Artists Artist { get; set; }


        [ForeignKey(nameof(Artist))]
        public int? ArtistId { get; set; }



        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<ReservationsServices> ConnectorReservationsServices { get; }


        public override string ToString()
        {
            return $"\n{this.Id,3} | {this.FanId,-20} {this.DateTime.Year,10}.{this.DateTime.Month}.{this.DateTime.Day} \t{this.ArtistId,15}";
        }
    }
}