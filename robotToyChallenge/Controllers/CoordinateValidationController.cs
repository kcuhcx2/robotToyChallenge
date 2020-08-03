using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using robotToyChallenge.Services.Coordinate.Validation;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class CoordinateValidationController: ControllerBase
    {
        private readonly ICoordinateValidationService _coordinateValidationService;

        public CoordinateValidationController(ICoordinateValidationService coordinateValidationService)
        {
            _coordinateValidationService = coordinateValidationService;
        }

        [HttpPost]
        public OperationResult<UpdateRobotCoordinatesModel> GetCoordinates([FromBody] Coordinates currentCoordinates)
        {

            var validation = _coordinateValidationService.DetermineRobotCommand(currentCoordinates);

            return validation;
        }
    }
}
