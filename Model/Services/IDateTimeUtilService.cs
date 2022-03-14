using Model.Models;

namespace Model.Services
{

    public interface IDateTimeUtilService
    {
        public float Convert(float days, TimeFormat format);
        public DateTime ToUtc(DateTime date, string timezoneId);
    }
}
