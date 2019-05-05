using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz.Library.Tests
{
    public class FizzBuzzerTests
    {
        [Theory]
        [InlineData (1), 
            InlineData (2), 
            InlineData(4), 
            InlineData(7), 
            InlineData(8), 
            InlineData(11), 
            InlineData(13), 
            InlineData(14), 
            InlineData(16), 
            InlineData(17), 
            InlineData(19)]
        public void Buzzer_WhenDefault_ReturnsInput(int input) {

            // Arrange

            // Act
            string output = FizzBuzzer.GetValue(input);

            // Assert
            Assert.Equal(input.ToString(), output);

        }

        [Theory]
        [InlineData (3), 
            InlineData(6), 
            InlineData(9), 
            InlineData(12), 
            InlineData(18)]
        
        public void Buzzer_WhenDiv3_ReturnsFizz(int input) {

            // Arrange

            // Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.Equal("Fizz", output);

        }

        [Theory]
        [InlineData(5), 
            InlineData(10), 
            InlineData(20)]

        public void Buzzer_WhenDiv5_ReturnsBuzz(int input) {

            // Arrange

            // Act
            string output = FizzBuzzer.GetValue(input);

            // Assert
            Assert.Equal("Buzz", output);
        }

        [Theory]
        [InlineData(15)]
        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz(int input) {

            // Arrange

            // Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.Equal("FizzBuzz", output);

        }
    }
}
