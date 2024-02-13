namespace SettingApi.Common;

public static class TypeConversionExtensions
{
    public static short ToShort(this object value)
    {
        return value is null ? throw new ArgumentNullException(nameof(value)) : Convert.ToInt16(value);
    }
}
