using Microsoft.AspNetCore.Mvc;

namespace MadLibsPoem.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public string Letter() { return "Our virtual postcard will go here soon!"; }

  }
}