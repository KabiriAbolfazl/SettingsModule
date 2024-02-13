using Microsoft.AspNetCore.Mvc;
using SettingApi.Filters;

namespace SettingApi.Controllers;

[Route("[controller]")]
[ApiController]
[ApiResultFilter]
public class BaseController : ControllerBase
{
}
