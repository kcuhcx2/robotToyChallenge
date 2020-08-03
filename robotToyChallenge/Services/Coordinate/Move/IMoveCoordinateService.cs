using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Move
{
    public interface IMoveCoordinateService
    {
        public OperationResult<CoordinateModel> UpdateCoordinates(Coordinates currentCoordinate);
    }
}
