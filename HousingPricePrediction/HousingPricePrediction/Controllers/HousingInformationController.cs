using Microsoft.AspNetCore.Mvc;
using HousingPricePrediction.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingPricePrediction.Controllers
{
    [Route("HousingInformation")]
    public class HousingInformationController : Controller
    {
        [HttpGet("HousingInformation/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakePrediction(HousingDataModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return View("Index");
        }
    }
}
