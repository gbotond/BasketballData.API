using BasketballData.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BasketballData.API.DbContexts
{
    public class BasketballDataContext : DbContext
    {
        public BasketballDataContext(DbContextOptions<BasketballDataContext> options)
           : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Team>().HasData(
                new Team()
                {
                    Id = Guid.Parse("f3495651-7a1a-4555-b1ab-c882ec688452"),
                    Name = "Boston Celtics",
                    ShortName = "BOS",
                    City = "Boston"
                },
                new Team()
                {
                    Id = Guid.Parse("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                    Name = "Los Angeles Lakers",
                    ShortName = "LAL",
                    City = "Los Angeles"
                },
                new Team()
                {
                    Id = Guid.Parse("f7df1739-96eb-4cbe-824a-2889289039c3"),
                    Name = "Utah Jazz",
                    ShortName = "UTA",
                    City = "Salt Lake City"
                },
                new Team()
                {
                    Id = Guid.Parse("0f759185-706d-4505-bf7e-0062873ac768"),
                    Name = "Chicago Bulls",
                    ShortName = "CHI",
                    City = "Chicago"
                },
                new Team()
                {
                    Id = Guid.Parse("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"),
                    Name = "Houston Rockets",
                    ShortName = "HOU",
                    City = "Houston"
                },
                new Team()
                {
                    Id = Guid.Parse("4bace877-9041-4870-8f2b-67674aa5d428"),
                    Name = "Orlando Magic",
                    ShortName = "ORL",
                    City = "Orlando"
                });

            modelBuilder.Entity<Game>().HasData(
               new Game
               {
                   Id = Guid.Parse("70bccd7b-ef46-4806-8435-a4481e2baf41"),
                   HomeTeamId = Guid.Parse("f3495651-7a1a-4555-b1ab-c882ec688452"),
                   VisitorTeamId = Guid.Parse("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                   Score = "88 - 98",
                   Started = new DateTime(2008, 06, 05, 20, 00, 00),
                   Finished = new DateTime(2008, 06, 05, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("fa54d4c4-83a3-4756-a70b-7e0741badb9b"),
                   HomeTeamId = Guid.Parse("f3495651-7a1a-4555-b1ab-c882ec688452"),
                   VisitorTeamId = Guid.Parse("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                   Score = "102 - 108",
                   Started = new DateTime(2008, 06, 08, 20, 00, 00),
                   Finished = new DateTime(2008, 06, 08, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("e9aa7ddb-908c-4c98-9799-3e569aa0ccf2"),
                   HomeTeamId = Guid.Parse("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                   VisitorTeamId = Guid.Parse("f3495651-7a1a-4555-b1ab-c882ec688452"),
                   Score = "81 - 87",
                   Started = new DateTime(2008, 06, 10, 20, 00, 00),
                   Finished = new DateTime(2008, 06, 10, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("ce44335f-c4d7-47f8-b604-4f55156fc4b5"),
                   HomeTeamId = Guid.Parse("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                   VisitorTeamId = Guid.Parse("f3495651-7a1a-4555-b1ab-c882ec688452"),
                   Score = "97 - 91",
                   Started = new DateTime(2008, 06, 12, 20, 00, 00),
                   Finished = new DateTime(2008, 06, 12, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("ce5bbca2-f7d1-4f88-ba0d-537553976d4b"),
                   HomeTeamId = Guid.Parse("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                   VisitorTeamId = Guid.Parse("f3495651-7a1a-4555-b1ab-c882ec688452"),
                   Score = "98 - 103",
                   Started = new DateTime(2008, 06, 15, 20, 00, 00),
                   Finished = new DateTime(2008, 06, 15, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("14310377-4f4d-479c-bdd9-688e48fb448e"),
                   HomeTeamId = Guid.Parse("f3495651-7a1a-4555-b1ab-c882ec688452"),
                   VisitorTeamId = Guid.Parse("e43e3c2e-caf8-4859-bb39-f62a5e273e16"),
                   Score = "92 - 131",
                   Started = new DateTime(2008, 06, 17, 20, 00, 00),
                   Finished = new DateTime(2008, 06, 17, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("07b15293-71f9-4edf-a17f-bdea5c06c720"),
                   HomeTeamId = Guid.Parse("f7df1739-96eb-4cbe-824a-2889289039c3"),
                   VisitorTeamId = Guid.Parse("0f759185-706d-4505-bf7e-0062873ac768"),
                   Score = "85 - 88",
                   Started = new DateTime(1998, 06, 03, 20, 00, 00),
                   Finished = new DateTime(1998, 06, 03, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("f02f04fd-8962-4acd-a59d-7777523695a7"),
                   HomeTeamId = Guid.Parse("f7df1739-96eb-4cbe-824a-2889289039c3"),
                   VisitorTeamId = Guid.Parse("0f759185-706d-4505-bf7e-0062873ac768"),
                   Score = "93 - 88",
                   Started = new DateTime(1998, 06, 05, 20, 00, 00),
                   Finished = new DateTime(1998, 06, 05, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("94b04b61-90fe-46fe-9f43-329fea2e1d47"),
                   HomeTeamId = Guid.Parse("0f759185-706d-4505-bf7e-0062873ac768"),
                   VisitorTeamId = Guid.Parse("f7df1739-96eb-4cbe-824a-2889289039c3"),
                   Score = "54 - 96",
                   Started = new DateTime(1998, 06, 07, 20, 00, 00),
                   Finished = new DateTime(1998, 06, 07, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("804781b3-b287-4c20-8883-ef8ca2c6b7e0"),
                   HomeTeamId = Guid.Parse("0f759185-706d-4505-bf7e-0062873ac768"),
                   VisitorTeamId = Guid.Parse("f7df1739-96eb-4cbe-824a-2889289039c3"),
                   Score = "82 - 86",
                   Started = new DateTime(1998, 06, 10, 20, 00, 00),
                   Finished = new DateTime(1998, 06, 10, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("1e1fac1a-476f-408e-8841-6f8d8eea3a15"),
                   HomeTeamId = Guid.Parse("0f759185-706d-4505-bf7e-0062873ac768"),
                   VisitorTeamId = Guid.Parse("f7df1739-96eb-4cbe-824a-2889289039c3"),
                   Score = "83 - 81",
                   Started = new DateTime(1998, 06, 12, 20, 00, 00),
                   Finished = new DateTime(1998, 06, 12, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("bb4018db-5c44-4fd3-9a94-39b5cfdb98ee"),
                   HomeTeamId = Guid.Parse("f7df1739-96eb-4cbe-824a-2889289039c3"),
                   VisitorTeamId = Guid.Parse("0f759185-706d-4505-bf7e-0062873ac768"),
                   Score = "87 - 86",
                   Started = new DateTime(1998, 06, 14, 20, 00, 00),
                   Finished = new DateTime(1998, 06, 14, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("17e4060c-91ce-4567-8512-634d92979092"),
                   HomeTeamId = Guid.Parse("4bace877-9041-4870-8f2b-67674aa5d428"),
                   VisitorTeamId = Guid.Parse("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"),
                   Score = "120 - 118 (OT)",
                   Started = new DateTime(1995, 06, 07, 20, 00, 00),
                   Finished = new DateTime(1995, 06, 07, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("7eeb7403-c229-4ddc-a07a-6a7d8961d497"),
                   HomeTeamId = Guid.Parse("4bace877-9041-4870-8f2b-67674aa5d428"),
                   VisitorTeamId = Guid.Parse("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"),
                   Score = "117 - 106",
                   Started = new DateTime(1995, 06, 09, 20, 00, 00),
                   Finished = new DateTime(1995, 06, 09, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("d691ac38-9b9c-41ab-996c-7ca4bc861163"),
                   HomeTeamId = Guid.Parse("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"),
                   VisitorTeamId = Guid.Parse("4bace877-9041-4870-8f2b-67674aa5d428"),
                   Score = "103 - 106",
                   Started = new DateTime(1995, 06, 11, 20, 00, 00),
                   Finished = new DateTime(1995, 06, 11, 22, 53, 32)
               },
               new Game
               {
                   Id = Guid.Parse("1cd65873-3e9b-4886-a8f3-5ab9cb5cc5bd"),
                   HomeTeamId = Guid.Parse("911b7b7b-a6c0-4311-82bf-d01376b7ae8a"),
                   VisitorTeamId = Guid.Parse("4bace877-9041-4870-8f2b-67674aa5d428"),
                   Score = "101 - 113",
                   Started = new DateTime(1995, 06, 14, 20, 00, 00),
                   Finished = new DateTime(1995, 06, 14, 22, 53, 32)
               });

            base.OnModelCreating(modelBuilder);
        }
    }
}
