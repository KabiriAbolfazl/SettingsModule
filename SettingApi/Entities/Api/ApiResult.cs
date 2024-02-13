using Microsoft.AspNetCore.Mvc;
using SettingApi.Common;
using System.Net;
using System.Reflection;
using System.Text.Json;

namespace SettingApi.Entities.Api;

public class ApiResult
{
    public bool IsSuccess { get; set; }
    public short StatusCode { get; set; }
    public string Message { get; set; }

    public ApiResult()
    {
    }

    public ApiResult(bool isSuccess, HttpStatusCode statusCode, string message = null)
    {
        IsSuccess = isSuccess;
        StatusCode = statusCode.ToShort();
        Message = message;
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }

    public static implicit operator ApiResult(BadRequestObjectResult result)
    {
        PropertyInfo pi = result.Value.GetType().GetProperty("Errors");
        Dictionary<string, string[]> errors = (Dictionary<string, string[]>)(pi.GetValue(result.Value, null));
        var message = result.ToString();
        var errorMessage = errors.SelectMany(p => p.Value).Distinct();
        message = string.Join(" | ", errorMessage);
        return new ApiResult(false, HttpStatusCode.BadRequest, message);
    }
}

public class QueryResult<T> : ApiResult
{
    public IEnumerable<T> Data { get; set; }
}
