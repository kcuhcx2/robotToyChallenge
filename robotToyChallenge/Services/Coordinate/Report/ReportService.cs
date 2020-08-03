using System;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Report
{
    public class ReportService: IReportService
    {
        public ReportService()
        {

        }

        public OperationResult<CoordinateModel> ReportCurrentCoordinates(Coordinates currentCoordinate)
        {
            return new OperationResult<CoordinateModel>(
                new CoordinateModel(currentCoordinate.Command,currentCoordinate.XCoordinate,
                currentCoordinate.YCoordinate,currentCoordinate.Facing)
            );
        }
    }
}
