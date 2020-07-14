namespace HousingPricePrediction.Models
{
    public class PredictionResult
    {
        public decimal Result { get; set; }
        public string ResultString => Result.ToString("C0");
    }
}
