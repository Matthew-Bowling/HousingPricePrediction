using Amazon.Lambda.Core;
using Amazon.SageMakerRuntime;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace MakeHousingPrediction
{
    public class MakePrediction
    {
       public async Task<double> Prediction(List<int> request)
       {
            var serializedRequest = JsonConvert.SerializeObject(request);
            var client = new AmazonSageMakerRuntimeClient();
            var sageMakerRequest = new Amazon.SageMakerRuntime.Model.InvokeEndpointRequest
            {
                EndpointName = "housing-regression-model",
                ContentType = "application/json",
                Body = new MemoryStream(Encoding.ASCII.GetBytes(serializedRequest))
            };
            try
            {
                var response = await client.InvokeEndpointAsync(sageMakerRequest);
                var streamReader = new StreamReader(response.Body);
                var responseBody = streamReader.ReadToEnd();
                var responseBodyString = "";
                foreach(var character in responseBody)
                {
                    if(character != '[' && character != ']')
                    {
                        responseBodyString += character;
                    }
                }
                Console.WriteLine(responseBodyString);
                return double.Parse(responseBodyString);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e);
                return 0;
            }
       }
    }
}
