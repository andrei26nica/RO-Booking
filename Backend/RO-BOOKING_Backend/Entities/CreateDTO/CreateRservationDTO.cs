﻿namespace RO_BOOKING_Backend.Entities.CreateDTO
{
    public class CreateRservationDTO
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IdUser { get; set; }
    }
}
