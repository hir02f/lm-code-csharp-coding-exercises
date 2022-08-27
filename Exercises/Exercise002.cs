using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            if (person == null)
            {
                return false;
            }
            else
            {
                return person.City == "Manchester";
            }
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            return person.Age >= ageLimit;
        }
    }
}
