using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SettingApi.Entities.Api;
using System.Net;

namespace SettingApi.Filters;

public class ApiResultFilterAttribute : ActionFilterAttribute
{
    public override void OnResultExecuting(ResultExecutingContext context)
    {
        if (context.Result is BadRequestObjectResult badRequestObjectResult)
        {
            System.Reflection.PropertyInfo pi = badRequestObjectResult.Value.GetType().GetProperty("Errors");
            Dictionary<string, string[]> errors = (Dictionary<string, string[]>)(pi.GetValue(badRequestObjectResult.Value, null));
            var message = badRequestObjectResult.ToString();
            if (errors is not null)
            {
                var errorMessage = errors.SelectMany(p => p.Value).Distinct();
                message = string.Join(" | ", errorMessage);
            }
            var apiResult = new ApiResult(false, HttpStatusCode.BadRequest, message);
            context.Result = new JsonResult(apiResult) { StatusCode = badRequestObjectResult.StatusCode };
        }
        base.OnResultExecuting(context);
    }
}
