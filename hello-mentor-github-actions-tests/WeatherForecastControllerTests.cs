using System;
using System.Linq;
using hello_mentor_app.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using Xunit;

namespace hello_mentor_github_actions_tests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_Should_Return_Tomorrow_As_First_Element()
        {
            //Arrange
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var expectedDate = DateTime.Now.Date;
            var sut = new WeatherForecastController(loggerMock.Object);

            //Act
            var result = sut.Get().ToList();

            //Assert
            Assert.NotEmpty(result);
            Assert.Equal(expectedDate, result.First().Date.Date);

        }
    }
}
