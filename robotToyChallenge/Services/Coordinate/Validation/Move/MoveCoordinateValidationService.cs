using System;
using System.Collections.Generic;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Validation.Move
{
    public class MoveCoordinateValidationService: IMoveCoordinateValidationService
    {
        public MoveCoordinateValidationService()
        {
        }

        public UpdateRobotCoordinatesModel CanUpdateRobot(Coordinates currentCoordinates)
        {
            if (currentCoordinates.Facing == CoordinateFacingConstants.EAST || currentCoordinates.Facing == CoordinateFacingConstants.WEST)
            {
                var isNotValid = IsXAxisOutOfBounds(currentCoordinates);
                if (isNotValid)
                {
                    return new UpdateRobotCoordinatesModel(false, new List<string> { "Please check your XAxis Coordinates" });
                }
                else
                {
                    return new UpdateRobotCoordinatesModel(true, new List<string>());
                }
            }
            else if (currentCoordinates.Facing == CoordinateFacingConstants.SOUTH || currentCoordinates.Facing == CoordinateFacingConstants.NORTH)
            {
                var isNotValid = IsYAxisOutOfBounds(currentCoordinates);
                if (isNotValid)
                {
                    return new UpdateRobotCoordinatesModel(false, new List<string> { "Please check your YAxis Coordinates" });
                }
                else
                {
                    return new UpdateRobotCoordinatesModel(true, new List<string>());
                }
            }

            return new UpdateRobotCoordinatesModel(false, new List<string> { "Please add a facing coordinate" });
        }

        private bool IsXAxisOutOfBounds(Coordinates currentCoordinates)
        {
            if (currentCoordinates.Facing == CoordinateFacingConstants.EAST)
            {
                var eastOutput = isEastOutOfBounds(currentCoordinates);
                return eastOutput;

            }
            else
            {
                var westOutput = isWestOutOfBounds(currentCoordinates);
                return westOutput;
            }
        }

        private bool IsYAxisOutOfBounds(Coordinates currentCoordinates)
        {
            if (currentCoordinates.Facing == CoordinateFacingConstants.NORTH)
            {
                var eastOutput = isNorthOutOfBounds(currentCoordinates);
                return eastOutput;

            }
            else
            {
                var westOutput = isSouthOutOfBounds(currentCoordinates);
                return westOutput;
            }
        }

        private bool isEastOutOfBounds(Coordinates currentCoordinates)
        {
            var combinedXAxisCoordinates = currentCoordinates.XCoordinate + 1;

            if (combinedXAxisCoordinates >= RobotGridSize.XAXIS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isWestOutOfBounds(Coordinates currentCoordinates)
        {
            var combinedXAxisCoordinates = currentCoordinates.XCoordinate - 1;

            if (combinedXAxisCoordinates < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isNorthOutOfBounds(Coordinates currentCoordinates)
        {
            var combinedYAxisCoordinates = currentCoordinates.YCoordinate + 1;

            if (combinedYAxisCoordinates > RobotGridSize.YAXIS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isSouthOutOfBounds(Coordinates currentCoordinates)
        {
            var combinedYAxisCoordinates = currentCoordinates.YCoordinate - 1;

            if (combinedYAxisCoordinates < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
