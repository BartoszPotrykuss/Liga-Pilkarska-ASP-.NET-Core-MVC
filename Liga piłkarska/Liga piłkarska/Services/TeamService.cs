using Liga_piłkarska.Models;
using System.Security.Cryptography.Pkcs;
using Liga_piłkarska.Services.Interfaces;

namespace Liga_piłkarska.Services
{
    public class TeamService : ITeamService
    {
       List<Team> teams = new List<Team>()
            {
                new Team
                {
                    Id = 1,
                    Name = "Test",
                    Players = new List<Player>
                    {
                        new Player
                        {
                            Id = 1,
                            Name = "Piotr",
                            Surname = "Kowal",
                        },
                        new Player
                        {
                            Id = 2,
                            Name = "Piotr",
                            Surname = "Kowal",
                        }
                    },
                }
            };

        public List<Team> GetTeams() 
        {
            return teams;
        }

        public Team GetById(int id)
        {
            var team = teams.Find(e => e.Id == id);
            return team;
        }
    }
}
