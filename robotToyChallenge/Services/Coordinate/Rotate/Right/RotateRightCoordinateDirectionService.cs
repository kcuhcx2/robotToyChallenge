using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Rotate.Right
{
    public class RotateRightCoordinateDirectionService : IRotateRightCoordinateDirectionService
    {
        public RotateRightCoordinateDirectionService()
        {
        }

        public OperationResult<CoordinateModel> RotateRobotToRight(Coordinates currentCoordinate)
        {
            var newFacingDirection = currentCoordinate.Facing;
            switch (currentCoordinate.Facing)
            {
                case CoordinateFacingConstants.EAST:
                    newFacingDirection = CoordinateFacingConstants.SOUTH;
                    break;

                case CoordinateFacingConstants.NORTH:
                    newFacingDirection = CoordinateFacingConstants.EAST;
                    break;

                case CoordinateFacingConstants.SOUTH:
                    newFacingDirection = CoordinateFacingConstants.WEST;
                    break;

                case CoordinateFacingConstants.WEST:
                    newFacingDirection = CoordinateFacingConstants.NORTH;
                    break;

                default:
                    break;

            }
            return new OperationResult<CoordinateModel>(new CoordinateModel(
                currentCoordinate.Command, currentCoordinate.XCoordinate, currentCoordinate.YCoordinate,
                newFacingDirection
            ));
        }
    }
}
