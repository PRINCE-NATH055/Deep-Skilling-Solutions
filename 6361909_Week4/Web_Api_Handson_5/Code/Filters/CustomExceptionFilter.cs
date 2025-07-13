using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace EmployeeWebApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            var logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "logs.txt");

            File.AppendAllText(logFilePath, $"[{DateTime.Now}] {exception.Message} {Environment.NewLine}");

            context.Result = new ObjectResult("Something went wrong on the server.")
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;
        }
    }
}
