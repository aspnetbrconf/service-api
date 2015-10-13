using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Dnx.Runtime;
using Microsoft.Dnx.Runtime.Infrastructure;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Data.Entity.Metadata;

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
          // foreach (var type in builder.Types)
          //     {
          //         foreach (var property in type.Properties)
          //         {
          //             if (property.ClrType == typeof(DateTime))
          //             {
          //                 builder.Entity(type.ClrType)
          //                     .Property(property.ClrType, property.Name)
          //                     .HasSqlServerColumnType("datetime2(0)");
          //             }
          //         }
          //     }


            // builder.Properties<string>()
            //             .Configure(c => c.HasMaxLength(100));

            base.OnModelCreating(builder);
        }
    }
}
