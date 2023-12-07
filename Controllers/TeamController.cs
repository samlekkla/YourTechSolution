using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using YourTechSolution.Models;

public class TeamController : Controller
{
    public IActionResult Index()
    {
        List<Team> teamLista = InitializeTeam();
        return View(teamLista);
    }

    private List<Team> InitializeTeam()
    {
        // Skapa och fyll listan med medarbetarinformation
        return new List<Team>
        {
            new Team { Name = "John Doe", Position = "Developer" , Image = "Guy.jpg" },
            new Team { Name = "Jane Doe", Position = "Designer", Image = "Guy.jpg" },
            new Team { Name = "Anne Doe", Position = "Administrator", Image = "Guy.jpg" },
            new Team { Name = "Sia Doe", Position = "Technichian", Image = "Guy.jpg" },
            // Lägg till fler medarbetare här
        };
    }
}