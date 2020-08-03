using System;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Validation.Move
{
    public interface IMoveCoordinateValidationService
    {
        public UpdateRobotCoordinatesModel CanUpdateRobot(Coordinates currentCoordinates);
    }
}
