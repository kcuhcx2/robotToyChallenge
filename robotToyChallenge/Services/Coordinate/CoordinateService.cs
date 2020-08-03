using System;
using System.Collections.Generic;
using robotToyChallenge.Services.Coordinate.Move;
using robotToyChallenge.Services.Coordinate.Place;
using robotToyChallenge.Services.Coordinate.Report;
using robotToyChallenge.Services.Coordinate.Rotate.Left;
using robotToyChallenge.Services.Coordinate.Rotate.Right;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate
{
    public class CoordinateService: ICoordinateService
    {
        private readonly IMoveCoordinateService _moveCoordinateService;
        private readonly IRotateLeftCoordinateDirectionService _rotateLeftCoordinateDirectionService;
        private readonly IRotateRightCoordinateDirectionService _rotateRightCoordinateDirectionService;
        private readonly IPlaceRobotService _placeRobotService;
        private readonly IReportService _reportService;
        public CoordinateService(IMoveCoordinateService moveCoordinateService,
            IRotateLeftCoordinateDirectionService rotateLeftCoordinateDirectionService,
            IRotateRightCoordinateDirectionService rotateRightCoordinateDirectionService,
            IPlaceRobotService placeRobotService, IReportService reportService)
        {
            _moveCoordinateService = moveCoordinateService;
            _rotateLeftCoordinateDirectionService = rotateLeftCoordinateDirectionService;
            _rotateRightCoordinateDirectionService = rotateRightCoordinateDirectionService;
            _placeRobotService = placeRobotService;
            _reportService = reportService;
        }

        public OperationResult<CoordinateModel> GetCoordinates()
        {

            var coordinates = new CoordinateModel(CoordinateCommandConstants.PLACE, 0, 0, CoordinateFacingConstants.NORTH);


            return new OperationResult<CoordinateModel>(coordinates);
        }

        public OperationResult<CoordinateModel> ExecuteCommand(Coordinates currentCoordinate)
        {
            switch (currentCoordinate.Command)
            {
                case CoordinateCommandConstants.LEFT:
                    return _rotateLeftCoordinateDirectionService.RotateRobotToLeft(currentCoordinate);

                case CoordinateCommandConstants.MOVE:
                    return _moveCoordinateService.UpdateCoordinates(currentCoordinate);

                case CoordinateCommandConstants.PLACE:
                    return _placeRobotService.PlaceRobotOnCoordinates(currentCoordinate);

                case CoordinateCommandConstants.REPORT:
                    return _reportService.ReportCurrentCoordinates(currentCoordinate);

                case CoordinateCommandConstants.RIGHT:
                    return _rotateRightCoordinateDirectionService.RotateRobotToRight(currentCoordinate);

                default:
                    throw new Exception("Could not find the current command");

            }
        }

    }

}
