﻿// <auto-generated />
using System;
using BasketballData.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasketballData.API.Migrations
{
    [DbContext(typeof(BasketballDataContext))]
    [Migration("20201022175218_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BasketballData.API.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("Finished")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HomeTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Score")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<DateTimeOffset>("Started")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("VisitorTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("VisitorTeamId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = new Guid("70bccd7b-ef46-4806-8435-a4481e2baf41"),
                            Finished = new DateTimeOffset(new DateTime(2008, 6, 5, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("f3495651-7a1a-4555-b1ab-c882ec688452"),
                            Score = "88 - 98",
                            Started = new DateTimeOffset(new DateTime(2008, 6, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16")
                        },
                        new
                        {
                            Id = new Guid("fa54d4c4-83a3-4756-a70b-7e0741badb9b"),
                            Finished = new DateTimeOffset(new DateTime(2008, 6, 8, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("f3495651-7a1a-4555-b1ab-c882ec688452"),
                            Score = "102 - 108",
                            Started = new DateTimeOffset(new DateTime(2008, 6, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16")
                        },
                        new
                        {
                            Id = new Guid("e9aa7ddb-908c-4c98-9799-3e569aa0ccf2"),
                            Finished = new DateTimeOffset(new DateTime(2008, 6, 10, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                            Score = "81 - 87",
                            Started = new DateTimeOffset(new DateTime(2008, 6, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("f3495651-7a1a-4555-b1ab-c882ec688452")
                        },
                        new
                        {
                            Id = new Guid("ce44335f-c4d7-47f8-b604-4f55156fc4b5"),
                            Finished = new DateTimeOffset(new DateTime(2008, 6, 12, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                            Score = "97 - 91",
                            Started = new DateTimeOffset(new DateTime(2008, 6, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("f3495651-7a1a-4555-b1ab-c882ec688452")
                        },
                        new
                        {
                            Id = new Guid("ce5bbca2-f7d1-4f88-ba0d-537553976d4b"),
                            Finished = new DateTimeOffset(new DateTime(2008, 6, 15, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                            Score = "98 - 103",
                            Started = new DateTimeOffset(new DateTime(2008, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("f3495651-7a1a-4555-b1ab-c882ec688452")
                        },
                        new
                        {
                            Id = new Guid("14310377-4f4d-479c-bdd9-688e48fb448e"),
                            Finished = new DateTimeOffset(new DateTime(2008, 6, 17, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("f3495651-7a1a-4555-b1ab-c882ec688452"),
                            Score = "92 - 131",
                            Started = new DateTimeOffset(new DateTime(2008, 6, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16")
                        },
                        new
                        {
                            Id = new Guid("07b15293-71f9-4edf-a17f-bdea5c06c720"),
                            Finished = new DateTimeOffset(new DateTime(1998, 6, 3, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("f7df1739-96eb-4cbe-824a-2889289039c3"),
                            Score = "85 - 88",
                            Started = new DateTimeOffset(new DateTime(1998, 6, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("0f759185-706d-4505-bf7e-0062873ac768")
                        },
                        new
                        {
                            Id = new Guid("f02f04fd-8962-4acd-a59d-7777523695a7"),
                            Finished = new DateTimeOffset(new DateTime(1998, 6, 5, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("f7df1739-96eb-4cbe-824a-2889289039c3"),
                            Score = "93 - 88",
                            Started = new DateTimeOffset(new DateTime(1998, 6, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("0f759185-706d-4505-bf7e-0062873ac768")
                        },
                        new
                        {
                            Id = new Guid("94b04b61-90fe-46fe-9f43-329fea2e1d47"),
                            Finished = new DateTimeOffset(new DateTime(1998, 6, 7, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("0f759185-706d-4505-bf7e-0062873ac768"),
                            Score = "54 - 96",
                            Started = new DateTimeOffset(new DateTime(1998, 6, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("f7df1739-96eb-4cbe-824a-2889289039c3")
                        },
                        new
                        {
                            Id = new Guid("804781b3-b287-4c20-8883-ef8ca2c6b7e0"),
                            Finished = new DateTimeOffset(new DateTime(1998, 6, 10, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("0f759185-706d-4505-bf7e-0062873ac768"),
                            Score = "82 - 86",
                            Started = new DateTimeOffset(new DateTime(1998, 6, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("f7df1739-96eb-4cbe-824a-2889289039c3")
                        },
                        new
                        {
                            Id = new Guid("1e1fac1a-476f-408e-8841-6f8d8eea3a15"),
                            Finished = new DateTimeOffset(new DateTime(1998, 6, 12, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("0f759185-706d-4505-bf7e-0062873ac768"),
                            Score = "83 - 81",
                            Started = new DateTimeOffset(new DateTime(1998, 6, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("f7df1739-96eb-4cbe-824a-2889289039c3")
                        },
                        new
                        {
                            Id = new Guid("bb4018db-5c44-4fd3-9a94-39b5cfdb98ee"),
                            Finished = new DateTimeOffset(new DateTime(1998, 6, 14, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("f7df1739-96eb-4cbe-824a-2889289039c3"),
                            Score = "87 - 86",
                            Started = new DateTimeOffset(new DateTime(1998, 6, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("0f759185-706d-4505-bf7e-0062873ac768")
                        },
                        new
                        {
                            Id = new Guid("17e4060c-91ce-4567-8512-634d92979092"),
                            Finished = new DateTimeOffset(new DateTime(1995, 6, 7, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("4bace877-9041-4870-8f2b-67674aa5d428"),
                            Score = "120 - 118 (OT)",
                            Started = new DateTimeOffset(new DateTime(1995, 6, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a")
                        },
                        new
                        {
                            Id = new Guid("7eeb7403-c229-4ddc-a07a-6a7d8961d497"),
                            Finished = new DateTimeOffset(new DateTime(1995, 6, 9, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("4bace877-9041-4870-8f2b-67674aa5d428"),
                            Score = "117 - 106",
                            Started = new DateTimeOffset(new DateTime(1995, 6, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a")
                        },
                        new
                        {
                            Id = new Guid("d691ac38-9b9c-41ab-996c-7ca4bc861163"),
                            Finished = new DateTimeOffset(new DateTime(1995, 6, 11, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"),
                            Score = "103 - 106",
                            Started = new DateTimeOffset(new DateTime(1995, 6, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("4bace877-9041-4870-8f2b-67674aa5d428")
                        },
                        new
                        {
                            Id = new Guid("1cd65873-3e9b-4886-a8f3-5ab9cb5cc5bd"),
                            Finished = new DateTimeOffset(new DateTime(1995, 6, 14, 22, 53, 32, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            HomeTeamId = new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"),
                            Score = "101 - 113",
                            Started = new DateTimeOffset(new DateTime(1995, 6, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            VisitorTeamId = new Guid("4bace877-9041-4870-8f2b-67674aa5d428")
                        });
                });

            modelBuilder.Entity("BasketballData.API.Entities.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f3495651-7a1a-4555-b1ab-c882ec688452"),
                            City = "Boston",
                            Name = "Boston Celtics",
                            ShortName = "BOS"
                        },
                        new
                        {
                            Id = new Guid("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                            City = "Los Angeles",
                            Name = "Los Angeles Lakers",
                            ShortName = "LAL"
                        },
                        new
                        {
                            Id = new Guid("f7df1739-96eb-4cbe-824a-2889289039c3"),
                            City = "Salt Lake City",
                            Name = "Utah Jazz",
                            ShortName = "UTA"
                        },
                        new
                        {
                            Id = new Guid("0f759185-706d-4505-bf7e-0062873ac768"),
                            City = "Chicago",
                            Name = "Chicago Bulls",
                            ShortName = "CHI"
                        },
                        new
                        {
                            Id = new Guid("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"),
                            City = "Houston",
                            Name = "Houston Rockets",
                            ShortName = "HOU"
                        },
                        new
                        {
                            Id = new Guid("4bace877-9041-4870-8f2b-67674aa5d428"),
                            City = "Orlando",
                            Name = "Orlando Magic",
                            ShortName = "ORL"
                        });
                });

            modelBuilder.Entity("BasketballData.API.Entities.Game", b =>
                {
                    b.HasOne("BasketballData.API.Entities.Team", "HomeTeam")
                        .WithMany("HomeGames")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BasketballData.API.Entities.Team", "VisitorTeam")
                        .WithMany("AwayGames")
                        .HasForeignKey("VisitorTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
