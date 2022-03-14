using Model.Models;

namespace Model.Services
{
    public class DateTimeUtilService : IDateTimeUtilService
    {
        public float Convert(float days, TimeFormat format)
        {
            switch (format)
            {
                case TimeFormat.SECONDS:
                    return days * 24 * 60 * 60;
                case TimeFormat.MINUTES:
                    return days * 24 * 60;
                case TimeFormat.HOURS:
                    return days * 24;
                case TimeFormat.YEARS:
                    return days / 365f;
                default:
                    return days;
            }
        }

        public DateTime ToUtc(DateTime date, string timezoneId)
        {
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(timezoneId);
            return TimeZoneInfo.ConvertTimeToUtc(date, tz);
        }
    }
}
