using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace AzureFunctionApp
{
    public static class MonitorFunction
    {
        [FunctionName("MonitorF1")]
        public static async Task<IActionResult> Run(
                    [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
                    ILogger log)
        {
            log.LogInformation("Our GitHub monitore proccess ...try"); //Logs

            string nameGet = req.Query["name"]; //get
            string method = "get";

            string namePost = "";
            string requestBody = string.Empty;
            using (StreamReader streamReader = new StreamReader(req.Body))
            {
                requestBody = await streamReader.ReadToEndAsync();
            }
            if (!string.IsNullOrEmpty(requestBody))
            {
                Dictionary<string, string> keyValuePairs = requestBody.Split(',').Select(value => value.Split('=')).ToDictionary(pair => pair[0], pair => pair[1]);
                namePost = keyValuePairs["name"].ToString(); //post
                method = "post";
            }

            string name = nameGet ?? namePost;
            log.LogInformation($"Try to set name=({name})");


            string responseMessage = string.IsNullOrEmpty(name)
                ? $"Function: no name"
                : $"Function ({method}): name   ( {name} )";

            return new OkObjectResult(responseMessage);
        }
    }
}

