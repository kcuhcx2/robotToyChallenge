using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Validation
{
    public interface ICoordinateValidationService
    {
        public OperationResult<UpdateRobotCoordinatesModel> DetermineRobotCommand(Coordinates currentCoordinates);
    }
}
