using Liga_piłkarska.Models;


namespace Liga_piłkarska.Services.Interfaces
{
    public interface ITeamService
    {
        List<Team> GetTeams();
        Team GetById(int id);
    }
}
