using System;
using Xunit;

namespace fizzBuzz
{
    public class fizzBuzzTest
    {
        [Fact]
        public void Number1Shout1()
        {
            //Arranges
            FizzBuzz fizzbuzz = new FizzBuzz();

            //Action
            fizzbuzz.inputNumber(1);
            string message = fizzbuzz.Shout();
            
            //Assert
            Assert.Equal("1", message);
        }
        [Fact]
        public void Number3ShoutFizz()
        {
            //Arrange
            FizzBuzz fizzbuzz = new FizzBuzz();

            //Action
            fizzbuzz.inputNumber(3);
            string message = fizzbuzz.Shout();

            //Assert
            Assert.Equal("Fizz", message);
        }

        [Fact]
        public void Number5ShoutBuzz()
        {
            //Arrange
            FizzBuzz fizzbuzz = new FizzBuzz();

            //Action
            fizzbuzz.inputNumber(5);
            string message = fizzbuzz.Shout();

            //Assert
            Assert.Equal("Buzz", message);
        }

        [Fact]
        public void Number15ShoutFizzBuzz()
        {
            //Arrange
            FizzBuzz fizzbuzz = new FizzBuzz();

            //Action
            fizzbuzz.inputNumber(15);
            string message = fizzbuzz.Shout();

            //Assert
            Assert.Equal("FizzBuzz", message);
        }
    }
}