namespace EventEaseAssignment1.Models
{
    public class Event
    {
        public int EventId { get; set; } // Primary Key for the event
        public string EventName { get; set; } // Name of the event (e.g., "Wedding Reception")
        public DateTime EventDate { get; set; } // The date and time the event takes place
        public string Description { get; set; } // A detailed description of the event (optional)
        public int VenueId { get; set; } // Foreign Key referring to the venue
        public Venue? Venue { get; set; } // Navigation property for the associated venue
        public ICollection<Booking>? Bookings { get; set; } // Navigation property for related bookings
    }
}
