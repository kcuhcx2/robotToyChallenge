using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Rotate.Left
{
    public interface IRotateLeftCoordinateDirectionService
    {
        public OperationResult<CoordinateModel> RotateRobotToLeft(Coordinates currentCoordinate);
    }
}
