using Microsoft.AspNetCore.Mvc;

namespace YourTechSolution.Controllers
{
    
      public class ContactController : Controller
      {
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult SubmitForm(string name, string email, string message)
            {
                // Hantera formulärdata här (t.ex. skicka e-post, spara i databasen)

                // Till exempel: skriv ut meddelandet till konsolen
                Console.WriteLine($"Received a message from {name} ({email}): {message}");

                // Returnera tillbaka till kontaktformuläret med en bekräftelse
                return RedirectToAction("Index");
            }
       }
    
}
