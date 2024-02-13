using Microsoft.AspNetCore.Mvc;
using SettingApi.Data;
using SettingApi.Entities.Builders;

namespace SettingApi.Controllers;

public class SettingsController : BaseController
{
    private readonly ApplicationDbContext _context;

    public SettingsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("{userId}/notification")]
    public async Task<ActionResult> GetUserNotificationSettings(Guid userId)
    {
        return Ok(
                new UserNotificationSettingsBuilder()
                    .WithEmailSettings(await _context.EmailSettings.FindAsync(userId))
                    .WithPushSettings(await _context.PushSettings.FindAsync(userId))
                    .WithSmsSettings(await _context.SmsSettings.FindAsync(userId))
                    .Build()
            );
    }
}

