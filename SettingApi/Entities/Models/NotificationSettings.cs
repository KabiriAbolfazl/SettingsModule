namespace SettingApi.Entities.Models;
public abstract class NotificationSettings
{
    public Guid UserId { get; set; }
    public bool IsEnabled { get; set; }
}

public class EmailSettings : NotificationSettings
{
    public bool IsMentionEnabled { get; set; }
    public bool IsDirectMessageEnabled { get; set; }
    public bool IsFollowEnabled { get; set; }
}

public class PushSettings : NotificationSettings
{
    public bool IsMentionEnabled { get; set; }
    public bool IsDirectMessageEnabled { get; set; }
    public bool IsFollowEnabled { get; set; }
}
public class SmsSettings : NotificationSettings
{
    public bool IsPasswordChangeEnabled { get; set; }
}