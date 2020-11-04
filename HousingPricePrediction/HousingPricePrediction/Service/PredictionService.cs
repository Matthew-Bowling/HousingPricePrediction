using Amazon;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Runtime;
using HousingPricePrediction.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace HousingPricePrediction.Service
{
    public class PredictionService
    {
        private readonly AmazonLambdaClient _client;

        public PredictionService()
        {
            var credentials = GetAwsCredentials();
            _client = new AmazonLambdaClient(credentials, RegionEndpoint.USEast1);
        }
        public async Task<decimal> GetPrediction(HousingDataModel modelData)
        {
            var data = new List<int> 
            {
                modelData.OverallQuality,
                modelData.GroundLivingArea,
                modelData.GarageCars,
                modelData.GarageArea,
                modelData.TotalBasementSquareFoot,
                modelData.FirstFloorSquareFoot,
                modelData.FullBath,
                modelData.TotalRoomsAboveGround,
                modelData.YearBuilt
            }; 
            var payload = JsonConvert.SerializeObject(data);
            var request = new InvokeRequest
            {
                FunctionName = "makehousingprediction-dev-prediction",
                InvocationType = InvocationType.RequestResponse,
                Payload = payload
            };
            decimal result = 0;
            try
            {
                var response = await _client.InvokeAsync(request);
                var streamReader = new StreamReader(response.Payload);
                var jsonReader = new JsonTextReader(streamReader);

                var serializer = new JsonSerializer();
                var deserializeResult = serializer.Deserialize(jsonReader);

                var stringResult = JsonConvert.SerializeObject(deserializeResult);
                result = decimal.Parse(stringResult);
            }
            catch(Exception e)
            {
                Console.Write(e);
            }
            return result; // replace with result for deserialization of lambda response
        }


        private static BasicAWSCredentials GetAwsCredentials()
        {
            return new BasicAWSCredentials();
        }
    }
}
