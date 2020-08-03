using System;
using System.Collections.Generic;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Validation.Place
{
    public class PlaceCoordinateValidationService: IPlaceCoordinateValidationService
    {
        public PlaceCoordinateValidationService()
        {
        }

        public UpdateRobotCoordinatesModel CanPlaceRobot(Coordinates currentCoordinates)
        {
            
            var facingList  = new List<string>
            {
                CoordinateFacingConstants.EAST,
                CoordinateFacingConstants.NORTH,
                CoordinateFacingConstants.SOUTH,
                CoordinateFacingConstants.WEST
            };


            if (!facingList.Contains(currentCoordinates.Facing))
            {
                return new UpdateRobotCoordinatesModel(false, new List<string> { "Please enter a Facing Command" });
            }

            if (currentCoordinates.XCoordinate +1 > RobotGridSize.XAXIS)
            {
                return new UpdateRobotCoordinatesModel(false, new List<string> { "Please enter a valid XAxis command" });
            }

            if (currentCoordinates.YCoordinate + 1 > RobotGridSize.YAXIS)
            {
                return new UpdateRobotCoordinatesModel(false, new List<string> { "Please enter a valid YAxis command" });
            }

            return new UpdateRobotCoordinatesModel(true, new List<string>());

        }
    }
}
