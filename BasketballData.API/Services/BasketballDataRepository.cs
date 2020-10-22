using BasketballData.API.DbContexts;
using BasketballData.API.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasketballData.API.Services
{
    public class BasketballDataRepository : IBasketballDataRepository, IDisposable
    {
        private readonly BasketballDataContext _context;

        public BasketballDataRepository(BasketballDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddGame(Guid homeTeamId, Guid visitorTeamId, Game game)
        {
            if (homeTeamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(homeTeamId));
            }

            if (visitorTeamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(visitorTeamId));
            }

            if (game == null)
            {
                throw new ArgumentNullException(nameof(game));
            }

            // always set the participating teams ids
            game.HomeTeamId = homeTeamId;
            game.VisitorTeamId = visitorTeamId;
            _context.Games.Add(game); 
        }         

        public void DeleteGame(Game game)
        {
            _context.Games.Remove(game);
        }

        public Game GetGameByParticipant(Guid teamId, Guid gameId)
        {
            if (teamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(teamId));
            }

            if (gameId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(gameId));
            }

            return _context.Games
              .Where(g => (g.HomeTeamId == teamId || g.VisitorTeamId == teamId) && g.Id == gameId).FirstOrDefault();
        }

        public Game GetGameByParticipants(Guid homeTeamId, Guid visitorTeamId, Guid gameId)
        {
            if (homeTeamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(homeTeamId));
            }

            if (visitorTeamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(visitorTeamId));
            }

            if (gameId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(gameId));
            }

            return _context.Games
              .Where(g => g.HomeTeamId == homeTeamId && g.VisitorTeamId == visitorTeamId && g.Id == gameId).FirstOrDefault();
        }

        public IEnumerable<Game> GetGamesByTeam(Guid teamId)
        {
            if (teamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(teamId));
            }

            return _context.Games
                        .Where(g => g.HomeTeamId == teamId || g.VisitorTeamId == teamId)
                        .OrderBy(g => g.Started).ToList();
        }

        public IEnumerable<Game> GetGamesByTeams(Guid homeTeamId, Guid visitorTeamId)
        {
            if (homeTeamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(homeTeamId));
            }

            if (visitorTeamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(visitorTeamId));
            }

            return _context.Games
                        .Where(g => g.HomeTeamId == homeTeamId && g.VisitorTeamId == visitorTeamId)
                        .OrderBy(g => g.Started).ToList();
        }

        public void UpdateGame(Game game)
        {
            // no code in this implementation
        }

        public void AddTeam(Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException(nameof(team));
            }

            // the repository fills the id (instead of using identity columns)
            team.Id = Guid.NewGuid();

            _context.Teams.Add(team);
        }

        public bool TeamExists(Guid teamId)
        {
            if (teamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(teamId));
            }

            return _context.Teams.Any(t => t.Id == teamId);
        }

        public void DeleteTeam(Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException(nameof(team));
            }

            _context.Teams.Remove(team);
        }
        
        public Team GetTeam(Guid teamId)
        {
            if (teamId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(teamId));
            }

            return _context.Teams.FirstOrDefault(t => t.Id == teamId);
        }

        public IEnumerable<Team> GetTeams()
        {
            return _context.Teams.ToList<Team>();
        }
         
        public IEnumerable<Team> GetTeams(IEnumerable<Guid> teamIds)
        {
            if (teamIds == null)
            {
                throw new ArgumentNullException(nameof(teamIds));
            }

            return _context.Teams.Where(t => teamIds.Contains(t.Id))
                .OrderBy(t => t.Name).ToList();
        }

        public void UpdateTeam(Team team)
        {
            // no code in this implementation
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
               // dispose resources when needed
            }
        }
    }
}
