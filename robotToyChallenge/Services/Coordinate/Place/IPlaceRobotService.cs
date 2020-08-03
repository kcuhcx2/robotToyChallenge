using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Place
{
    public interface IPlaceRobotService
    {
        public OperationResult<CoordinateModel> PlaceRobotOnCoordinates(Coordinates currentCoordinate);
    }
}
