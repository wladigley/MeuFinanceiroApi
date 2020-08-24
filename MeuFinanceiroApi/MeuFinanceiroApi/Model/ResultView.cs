using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Model
{
    public class ResultView
    {
        public bool success { get; set; }
        public object content { get; set; }
        public string error { get; set; }
        public string uriInformation { get; set; }
        //Success
        public static OkObjectResult Success(object content) => new OkObjectResult(new { result = true, content });
        public static OkObjectResult Success(object content, string message) => new OkObjectResult(new { result = true, content });

        //Warning
        public static BadRequestObjectResult Warning(string message) => new BadRequestObjectResult(new { result = false, message });

        //Error
        public static BadRequestObjectResult Error(Exception exception, string objectSplitable = null) => new BadRequestObjectResult(new
        {
            result = false,
            exception,
            message = objectSplitable != null ? exception.Message.Split('|')[1] : exception.Message,
            messages = objectSplitable != null ? exception.Message.Split('|').Where(m => m != "S") : null
        });
    }
}
