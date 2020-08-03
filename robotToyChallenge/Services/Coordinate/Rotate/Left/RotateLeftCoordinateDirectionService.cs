using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Rotate.Left
{
    public class RotateLeftCoordinateDirectionService: IRotateLeftCoordinateDirectionService
    {
        public RotateLeftCoordinateDirectionService()
        {
        }

        public OperationResult<CoordinateModel> RotateRobotToLeft(Coordinates currentCoordinate)
        {
            var newFacingDirection = currentCoordinate.Facing;
            switch (currentCoordinate.Facing)
            {
                case CoordinateFacingConstants.EAST:
                    newFacingDirection = CoordinateFacingConstants.NORTH;
                    break;

                case CoordinateFacingConstants.NORTH:
                    newFacingDirection = CoordinateFacingConstants.WEST;
                    break;

                case CoordinateFacingConstants.SOUTH:
                    newFacingDirection = CoordinateFacingConstants.EAST;
                    break;

                case CoordinateFacingConstants.WEST:
                    newFacingDirection = CoordinateFacingConstants.SOUTH;
                    break;

                default:
                    break;

            }
            return new OperationResult<CoordinateModel>(new CoordinateModel(
                currentCoordinate.Command,currentCoordinate.XCoordinate,currentCoordinate.YCoordinate,
                newFacingDirection
            ));
        }
    }
}
