using System;
using System.Globalization;

namespace DateTime_Local
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo swedishCulture = new CultureInfo("sv-SE");
            DateTimeFormatInfo swedishDateFormat = swedishCulture.DateTimeFormat;

            CultureInfo hungarianCulture = new CultureInfo("hu-HU");
            DateTimeFormatInfo hungarianDateFormat = hungarianCulture.DateTimeFormat;

            CultureInfo germanCulture = new CultureInfo("de-DE");
            DateTimeFormatInfo germanDateFormat = germanCulture.DateTimeFormat;

            CultureInfo zhcnCulture = new CultureInfo("zh-CN");
            DateTimeFormatInfo zhcnDateFormat = zhcnCulture.DateTimeFormat;

            DateTime now = DateTime.Now;

            string formattedDateSweden = now.ToString(swedishDateFormat.FullDateTimePattern);
            string formattedDateHungary = now.ToString(hungarianDateFormat.FullDateTimePattern);
            string formattedDateGermany = now.ToString(germanDateFormat.FullDateTimePattern);
            string formattedDateZhcn = now.ToString(zhcnDateFormat.FullDateTimePattern);

            Console.WriteLine(formattedDateSweden);
            Console.WriteLine(formattedDateHungary);
            Console.WriteLine(formattedDateGermany);
            Console.WriteLine(formattedDateZhcn);

            Console.ReadKey();
        }
    }
}
