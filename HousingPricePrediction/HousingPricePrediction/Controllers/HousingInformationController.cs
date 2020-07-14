using Microsoft.AspNetCore.Mvc;
using HousingPricePrediction.Models;
using HousingPricePrediction.Service;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HousingPricePrediction.Controllers
{
    [Route("HousingInformation")]
    public class HousingInformationController : Controller
    {
        private PredictionService _predictionService;

        public HousingInformationController()
        {
            _predictionService = new PredictionService(); //Dependency Injection That shit
        }

        [HttpGet("HousingInformation/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> MakePrediction(HousingDataModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("Index", model);
            }

            var predictedValue = await _predictionService.GetPrediction(model);
            var resultModel = new PredictionResult
            {
                Result = predictedValue
            };

            return View("PredictionResult", resultModel);
        }
    }
}
