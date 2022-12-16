using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.API.Data.Entities;
using BookingApp.BookingApp.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.BookingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Booking> bookings {get;set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Room>()
                .HasOne(u => u.RoomType)
                .WithMany(r => r.Rooms)
                .HasForeignKey(u=>u.RoomTypeId);
            base.OnModelCreating(builder);

            builder.Entity<>
        }

    }
}