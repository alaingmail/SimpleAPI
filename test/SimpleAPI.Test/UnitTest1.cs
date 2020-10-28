using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Linq;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
      WeatherForecastController controller = new WeatherForecastController();

      [Fact]
      public void TestReturnsAllWeatherForcasts()
      {
        var returnValues = controller.Get();
        Assert.Equal(5, returnValues.Count());
      }
    }
}
