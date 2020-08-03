using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Move
{
    public class MoveCoordinateService: IMoveCoordinateService
    {
        public MoveCoordinateService()
        {
        }

        public OperationResult<CoordinateModel> UpdateCoordinates(Coordinates currentCoordinate)
        {
            switch (currentCoordinate.Facing)
            {
                case CoordinateFacingConstants.EAST:
                    return new OperationResult<CoordinateModel>(new CoordinateModel(
                        currentCoordinate.Command,currentCoordinate.XCoordinate + 1,
                        currentCoordinate.YCoordinate, currentCoordinate.Facing
                    ));

                case CoordinateFacingConstants.NORTH:
                    return new OperationResult<CoordinateModel>(new CoordinateModel(
                        currentCoordinate.Command, currentCoordinate.XCoordinate,
                        currentCoordinate.YCoordinate + 1, currentCoordinate.Facing
                    ));

                case CoordinateFacingConstants.SOUTH:
                    return new OperationResult<CoordinateModel>(new CoordinateModel(
                        currentCoordinate.Command, currentCoordinate.XCoordinate,
                        currentCoordinate.YCoordinate - 1, currentCoordinate.Facing
                    ));

                case CoordinateFacingConstants.WEST:
                    return new OperationResult<CoordinateModel>(new CoordinateModel(
                        currentCoordinate.Command, currentCoordinate.XCoordinate - 1,
                        currentCoordinate.YCoordinate, currentCoordinate.Facing
                    ));

                default:
                    return new OperationResult<CoordinateModel>(new CoordinateModel(
                        currentCoordinate.Command, currentCoordinate.XCoordinate,
                        currentCoordinate.YCoordinate, currentCoordinate.Facing
                    ));

            }
        }
    }
}
