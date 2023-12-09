using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using YourTechSolution.Models;

public class TeamController : Controller
{
    public List<Team> Teams { get; }

    public IActionResult Index()
    {
        var teamList = InitializeTeam(); // Replace this with logic to get the team list
        var teamViewModel = new TeamViewModel { Teams = teamList };
        return View(teamViewModel);
    }

    private List<Team> InitializeTeam()
    {
        // Create and populate the list with team information
        return new List<Team>
        {
            new Team { Name = "John Doe", Position = "Developer", Image = "Guy.jpg" },
            new Team { Name = "Jane Doe", Position = "Designer", Image = "Guy.jpg" },
            new Team { Name = "Anne Doe", Position = "Administrator", Image = "Guy.jpg" },
            new Team { Name = "Sia Doe", Position = "Technician", Image = "Guy.jpg" }
            
        };
    }
}
