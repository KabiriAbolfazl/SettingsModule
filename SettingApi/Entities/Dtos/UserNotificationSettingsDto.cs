using SettingApi.Entities.Models;

namespace SettingApi.Entities.Dtos;

public class UserNotificationSettingsDto
{
    public EmailSettings Email { get; set; }
    public PushSettings Push { get; set; }
    public SmsSettings Sms { get; set; }
}
