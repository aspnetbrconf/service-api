using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Dnx.Runtime;
using Microsoft.Dnx.Runtime.Infrastructure;
using Microsoft.Framework.DependencyInjection;

namespace AspnetBr.Api.Models
{
    public class AspnetBrContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Local> Locals { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}
