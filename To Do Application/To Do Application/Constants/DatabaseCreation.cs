using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using To_Do_Application.DTO;

namespace To_Do_Application.Constants
{
    public class DatabaseCreation : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Debug.WriteLine("GETTING INTO MY DB METHOD");
            //System.Data.SQLite.SQLiteConnection.CreateFile("todo.db");
            optionsBuilder.UseSqlite($"Data Source=todo.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData
            (
                new User()
                {
                    Id = 1,
                    name = "Arata",
                    surname = "Yano",
                    username = "aratayano00@gmail.com",
                    password = "Password123"
                },
                new User()
                {
                    Id = 2,
                    name = "Carah",
                    surname = "Prinsloo",
                    username = "carahprinsloo99@gmail.com",
                    password = "Password123"
                }
            );
        }
    }
}