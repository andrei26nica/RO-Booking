﻿namespace RO_BOOKING_Backend.Entities
{
    public class Destination
    {
        public int Id { get; set; }
        public int Budget {get; set; }
        public int DestinationTypeId { get; set; }
        public virtual DestinationType DestinationTypes { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public int LocationId { get; set; }
        public virtual Location Locations { get; set; }
    }
}
