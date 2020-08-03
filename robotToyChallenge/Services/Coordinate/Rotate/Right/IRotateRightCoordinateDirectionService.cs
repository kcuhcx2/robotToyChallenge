using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Rotate.Right
{
    public interface IRotateRightCoordinateDirectionService
    {
        public OperationResult<CoordinateModel> RotateRobotToRight(Coordinates currentCoordinate);
    }
}
