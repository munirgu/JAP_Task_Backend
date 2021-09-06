using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace JAP_Task_Backend.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Video> Videos { get; set; }

        public DbSet<VideoActor> VideoActors { get; set; }

        public DbSet<Rating> Ratings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Videos Data
            modelBuilder.Entity<Video>().HasData(
                new Video
                {
                    Id = 1,
                    Title = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency",
                    ReleaseDate = new DateTime(2021, 4, 12),
                    Type = VideoType.Movie,
                    ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                    
                }


            );
            #endregion



            #region VideosActors Data
            modelBuilder.Entity<VideoActor>().HasData(
                new VideoActor { Id = 1, Name = "Munir", VideoId = 1 },
                new VideoActor { Id = 2, Name = "Munir2", VideoId = 1 }


            );
            #endregion


            #region VideosActors Data
            modelBuilder.Entity<Rating>().HasData(
                new Rating { Id = 1, Score=3, VideoId = 1 },
                new Rating { Id = 2, Score=5, VideoId = 1 }


            );
            #endregion




        }

    }

}
