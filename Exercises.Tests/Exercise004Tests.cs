using NUnit.Framework;
using FluentAssertions;
using System;

namespace Exercises.Tests
{
    public class Exercise004Tests
    {
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Only_Date_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 7, 19));
            DateTime expectedResult = new(2053, 3, 27, 1, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 3, 4, 23, 22, 0, 0));
            DateTime expectedResult = new(2052, 11, 11, 1, 8, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified_With_Day_RollOver()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 1, 24, 23, 59, 59, 0));
            DateTime expectedResult = new(2052, 10, 3, 1, 46, 39);
            actualResult.Should().Be(expectedResult);
        }

        // my tests
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Ticks_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(0));
            DateTime expectedResult = new DateTime(10000000000000000);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Throw_Argument_Exception_When_Bigger_Than_Max_Ticks()
        {            
            var ex = Assert.Throws<ArgumentException>(() => Exercise004.AddGigaSecond(new DateTime(DateTime.MaxValue.Ticks)));
            Assert.That(ex.Message, Is.EqualTo("Answer is bigger than maximum datetime value!"));

            ex = Assert.Throws<ArgumentException>(() => Exercise004.AddGigaSecond(new DateTime(DateTime.MaxValue.Ticks-999999999999999)));
            Assert.That(ex.Message, Is.EqualTo("Answer is bigger than maximum datetime value!"));
        }
    }
}
