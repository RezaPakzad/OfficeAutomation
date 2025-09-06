using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeAutomation.Infrastructure.Helpers
{
    public static class DateTimeHelper
    {
        public static string DateShamsi()
        {
            var pc = new PersianCalendar();
            var now = DateTime.Now;
            return $"{pc.GetYear(now)}/{pc.GetMonth(now):D2}/{pc.GetDayOfMonth(now):D2}";
        }

        public static DateTime DateMiladi()
        {
            return DateTime.Now;
        }
    }
}
