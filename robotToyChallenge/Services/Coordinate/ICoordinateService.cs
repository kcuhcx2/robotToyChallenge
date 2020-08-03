using System;
using System.Collections.Generic;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate
{
    public interface ICoordinateService
    {
        public OperationResult<CoordinateModel> GetCoordinates();
        public OperationResult<CoordinateModel> ExecuteCommand(Coordinates currentCoordinate);
    }
}
