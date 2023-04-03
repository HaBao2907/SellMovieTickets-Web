using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors_Movies>().HasKey(am => new
            {
                am.Id,
                am.MovieId
            });
            modelBuilder.Entity<Actors_Movies>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey( m => m.MovieId );
            modelBuilder.Entity<Actors_Movies>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.Id);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actors_Movies> Actors_Movies { get; set;}
        public DbSet<Cinema> Cinema { get; set; }   
        public DbSet<Producer> Producers { get; set; }  

    }
}
