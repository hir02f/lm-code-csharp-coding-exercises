using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            // As Ticks is in 100-nanoseconds
            if ((dateTime.Ticks + 10000000000000000) > DateTime.MaxValue.Ticks)
            {
                throw new ArgumentException("Answer is bigger than maximum datetime value!");
            }
            else
            {
                return new DateTime(10000000000000000 + dateTime.Ticks);
            }
        }
    }
}
