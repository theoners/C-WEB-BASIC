namespace SharedTrip.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
   
    using static Data.Constant.TripConstant;
    public class Trip
    {
       public Trip()
        {
            this.UserTrips = new HashSet<UserTrip>();
        }
        public string Id { get; set; }
        
        [Required]
        public string StartPoint { get; set; }
        
        [Required]
        public string EndPoint { get; set; }
        
        [Required]
        public DateTime DepartureTime { get; set; }

        [MaxLength(SeatsMaxLength)]
        [Required]
        public int Seats { get; set; }
        
        [MaxLength(DescriptionMaxLength)]
        [Required]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public virtual ICollection<UserTrip> UserTrips { get; set; }

    }
}
