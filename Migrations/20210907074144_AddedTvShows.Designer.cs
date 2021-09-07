﻿// <auto-generated />
using System;
using JAP_Task_Backend.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JAP_Task_Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210907074144_AddedTvShows")]
    partial class AddedTvShows
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JAP_Task_Backend.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("VideoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VideoId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Score = 3,
                            VideoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Score = 5,
                            VideoId = 1
                        },
                        new
                        {
                            Id = 3,
                            Score = 4,
                            VideoId = 2
                        },
                        new
                        {
                            Id = 4,
                            Score = 2,
                            VideoId = 2
                        },
                        new
                        {
                            Id = 5,
                            Score = 4,
                            VideoId = 3
                        },
                        new
                        {
                            Id = 6,
                            Score = 5,
                            VideoId = 3
                        },
                        new
                        {
                            Id = 7,
                            Score = 5,
                            VideoId = 4
                        },
                        new
                        {
                            Id = 8,
                            Score = 5,
                            VideoId = 4
                        },
                        new
                        {
                            Id = 9,
                            Score = 5,
                            VideoId = 5
                        },
                        new
                        {
                            Id = 10,
                            Score = 5,
                            VideoId = 5
                        });
                });

            modelBuilder.Entity("JAP_Task_Backend.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Videos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Saving Private Ryan is a 1998 American epic war film directed by Steven Spielberg and written by Robert Rodat. Set during the Invasion of Normandy in World War II, the film is known for its graphic portrayal of war, especially its depiction of the Omaha Beach assault during the Normandy landings.",
                            ImageUrl = "https://fanart.tv/fanart/movies/857/movieposter/saving-private-ryan-521a5ad8ab73e.jpg",
                            ReleaseDate = new DateTime(1998, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Saving Private Ryan",
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dominic Cobb is an industrial spy who instead of breaking into a person's home, office, or even computer, gets the information he needs by getting into the person's mind through their dreams.",
                            ImageUrl = "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg",
                            ReleaseDate = new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception",
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "The witcher Geralt, a mutated monster hunter, struggles to find his place in a world in which people often prove more wicked than beasts.",
                            ImageUrl = "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg",
                            ReleaseDate = new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Witcher",
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Forrest Gump is a 1994 American drama film directed by Robert Zemeckis and written by Eric Roth with comedic aspects. It is based on the 1986 novel of the same name by Winston Groom and stars Tom Hanks, Robin Wright, Gary Sinise, Mykelti Williamson and Sally Field.",
                            ImageUrl = "https://cinecalidad.in/wp-content/uploads/2020/03/forrest-gump-7240-poster-683x1024.jpg",
                            ReleaseDate = new DateTime(1994, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Forrest Gump",
                            Type = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Forrest Gump is a 1994 American drama film directed by Robert Zemeckis and written by Eric Roth with comedic aspects. It is based on the 1986 novel of the same name by Winston Groom and stars Tom Hanks, Robin Wright, Gary Sinise, Mykelti Williamson and Sally Field.",
                            ImageUrl = "https://cinecalidad.in/wp-content/uploads/2020/03/forrest-gump-7240-poster-683x1024.jpg",
                            ReleaseDate = new DateTime(1994, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Forrest Gump",
                            Type = 2
                        });
                });

            modelBuilder.Entity("JAP_Task_Backend.Models.VideoActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VideoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VideoId");

                    b.ToTable("VideoActors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tom Hanks",
                            VideoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Matt Damon",
                            VideoId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Leonardo DiCaprio",
                            VideoId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Joseph Gordon-Levitt",
                            VideoId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Henry Cavill",
                            VideoId = 3
                        },
                        new
                        {
                            Id = 6,
                            Name = "Anna Shaffer",
                            VideoId = 3
                        },
                        new
                        {
                            Id = 7,
                            Name = "Tom Hanks",
                            VideoId = 4
                        },
                        new
                        {
                            Id = 8,
                            Name = "Robin Wright",
                            VideoId = 4
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tom Hanks",
                            VideoId = 5
                        },
                        new
                        {
                            Id = 10,
                            Name = "Robin Wright",
                            VideoId = 5
                        });
                });

            modelBuilder.Entity("JAP_Task_Backend.Models.Rating", b =>
                {
                    b.HasOne("JAP_Task_Backend.Models.Video", "Video")
                        .WithMany("Ratings")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Video");
                });

            modelBuilder.Entity("JAP_Task_Backend.Models.VideoActor", b =>
                {
                    b.HasOne("JAP_Task_Backend.Models.Video", "Video")
                        .WithMany("Actors")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Video");
                });

            modelBuilder.Entity("JAP_Task_Backend.Models.Video", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}