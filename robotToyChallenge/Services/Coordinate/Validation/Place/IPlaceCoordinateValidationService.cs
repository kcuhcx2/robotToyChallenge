using System;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Validation.Place
{
    public interface IPlaceCoordinateValidationService
    {
        public UpdateRobotCoordinatesModel CanPlaceRobot(Coordinates currentCoordinates);
    }
}
