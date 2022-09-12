using Microsoft.AspNetCore.Mvc;

namespace Contest.Controllers
{
    public class ContestController : Controller
    {
        public IActionResult Contest()
        {
            return View();
        }
    }
}
