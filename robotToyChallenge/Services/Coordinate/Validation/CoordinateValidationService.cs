using System;
using System.Collections.Generic;
using robotToyChallenge.Services.Coordinate.Validation.Move;
using robotToyChallenge.Services.Coordinate.Validation.Place;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Services.Coordinate.Validation
{
    public class CoordinateValidationService: ICoordinateValidationService
    {

        private readonly IMoveCoordinateValidationService _moveCoordinateValidationService;
        private readonly IPlaceCoordinateValidationService _placeCoordinateValidationService;

        public CoordinateValidationService(IMoveCoordinateValidationService moveCoordinateValidationService, IPlaceCoordinateValidationService placeCoordinateValidationService)
        {
            _moveCoordinateValidationService = moveCoordinateValidationService;
            _placeCoordinateValidationService = placeCoordinateValidationService;
        }

        public OperationResult<UpdateRobotCoordinatesModel> DetermineRobotCommand(Coordinates currentCoordinates)
        {
            var validResponse = new UpdateRobotCoordinatesModel(true, new List<string>());

            switch (currentCoordinates.Command)
            {
                case CoordinateCommandConstants.MOVE:
                    var moveValidation = _moveCoordinateValidationService.CanUpdateRobot(currentCoordinates);
                    return new OperationResult<UpdateRobotCoordinatesModel>(moveValidation);

                case CoordinateCommandConstants.PLACE:
                    var initialRobotPlacement = _placeCoordinateValidationService.CanPlaceRobot(currentCoordinates);
                    return new OperationResult<UpdateRobotCoordinatesModel>(initialRobotPlacement);

                case CoordinateCommandConstants.REPORT:
                    return new OperationResult<UpdateRobotCoordinatesModel>(validResponse);

                case CoordinateCommandConstants.LEFT:
                    return new OperationResult<UpdateRobotCoordinatesModel>(validResponse);

                case CoordinateCommandConstants.RIGHT:
                    return new OperationResult<UpdateRobotCoordinatesModel>(validResponse);

                default:
                    var invalidCommand = new UpdateRobotCoordinatesModel(false, new List<string> { "Please enter a valid Coordinate Command" });
                    return new OperationResult<UpdateRobotCoordinatesModel>(invalidCommand);

            }
        }

    }
}
