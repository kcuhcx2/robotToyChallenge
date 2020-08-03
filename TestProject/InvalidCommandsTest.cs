using System;
using robotToyChallenge.Services.Coordinate.Validation;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;
using Xunit;

namespace robotToyChallenge.Tests
{
    public class InvalidCommandsTest
    {
        private readonly ICoordinateValidationService _coordinateValidationService;

        public InvalidCommandsTest(ICoordinateValidationService coordinateValidationService)
        {
            _coordinateValidationService = coordinateValidationService;
        }

        [Fact]
        public void TestInvalidCommands()
        {
            var coordinates1 = new Coordinates();

            var invalid1 = _coordinateValidationService.DetermineRobotCommand(coordinates1);

            Assert.False(invalid1.Data.CanUpdateRobotCoordinate);

        }

    }
}
