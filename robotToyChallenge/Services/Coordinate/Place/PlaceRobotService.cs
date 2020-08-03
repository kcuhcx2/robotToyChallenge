using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Place
{
    public class PlaceRobotService: IPlaceRobotService
    {
        public PlaceRobotService()
        {
        }

        public OperationResult<CoordinateModel> PlaceRobotOnCoordinates(Coordinates currentCoordinate)
        {
            return new OperationResult<CoordinateModel>(new CoordinateModel(
                currentCoordinate.Command, currentCoordinate.XCoordinate,
                currentCoordinate.YCoordinate, currentCoordinate.Facing
            ));
        }
    }
}
