using BasketballData.API.Entities;
using System;
using System.Collections.Generic;

namespace BasketballData.API.Services
{
    public interface IBasketballDataRepository
    {    
        IEnumerable<Game> GetGamesByTeam(Guid TeamId);
        Game GetGameByParticipants(Guid homeTeamId, Guid visitorTeamId, Guid gameId);
        void AddGame(Guid homeTeamId, Guid visitorTeamId, Game game);
        void UpdateGame(Game game);
        void DeleteGame(Game game);
        IEnumerable<Team> GetTeams();
        Team GetTeam(Guid teamId);
        IEnumerable<Team> GetTeams(IEnumerable<Guid> teamIds);
        void AddTeam(Team team);
        void DeleteTeam(Team team);
        void UpdateTeam(Team team);
        bool TeamExists(Guid teamId);
        bool Save();
    }
}
