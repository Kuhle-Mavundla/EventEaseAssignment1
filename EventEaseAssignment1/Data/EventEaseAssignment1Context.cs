using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventEaseAssignment1.Models;

namespace EventEaseAssignment1.Data
{
    public class EventEaseAssignment1Context : DbContext
    {
        public EventEaseAssignment1Context (DbContextOptions<EventEaseAssignment1Context> options)
            : base(options)
        {
        }

        public DbSet<EventEaseAssignment1.Models.Venue> Venue { get; set; } = default!;
        public DbSet<EventEaseAssignment1.Models.Event> Event { get; set; } = default!;
        public DbSet<EventEaseAssignment1.Models.Booking> Booking { get; set; } = default!;
    }
}
