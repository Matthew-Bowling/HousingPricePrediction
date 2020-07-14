namespace MakeHousingPrediction
{
    public class Request
    {
        public int OverallQuality { get; set; }
        public int GroundLivingArea { get; set; }
        public int GarageCars { get; set; }
        public int GarageArea { get; set; }
        public int TotalBasementSquareFoot { get; set; }
        public int FirstFloorSquareFoot { get; set; }
        public int FullBath { get; set; }
        public int TotalRoomsAboveGround { get; set; }
        public int YearBuilt { get; set; }
    }
}
