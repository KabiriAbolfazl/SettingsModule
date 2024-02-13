using SettingApi.Entities.Dtos;
using SettingApi.Entities.Models;

namespace SettingApi.Entities.Builders;

public class UserNotificationSettingsBuilder
{

    private UserNotificationSettingsDto _response = new();

    public UserNotificationSettingsBuilder WithEmailSettings(EmailSettings settings)
    {
        _response.Email = settings;
        return this;
    }

    public UserNotificationSettingsBuilder WithPushSettings(PushSettings settings)
    {
        _response.Push = settings;
        return this;
    }

    public UserNotificationSettingsBuilder WithSmsSettings(SmsSettings settings)
    {
        _response.Sms = settings;
        return this;
    }

    public UserNotificationSettingsDto Build() => _response;



}
