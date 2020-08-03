using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Report
{
    public interface IReportService
    {
        public OperationResult<CoordinateModel> ReportCurrentCoordinates(Coordinates currentCoordinate);
    }
}
