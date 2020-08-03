using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using robotToyChallenge.Services.Coordinate;
using robotToyChallenge.Shared;
using robotToyChallenge.ViewModels;

namespace robotToyChallenge.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class CoordinateController: ControllerBase
    {
        private readonly ICoordinateService _coordinateService;

        public CoordinateController(ICoordinateService coordinateService)
        {
            _coordinateService = coordinateService;
        }

        [HttpGet]
        public OperationResult<CoordinateModel> GetCoordinates()
        {
            var coordinates = _coordinateService.GetCoordinates();

            return coordinates;
        }

        [HttpPost]
        public OperationResult<CoordinateModel> UpdateCoordinates([FromBody] Coordinates currentCoordinates)
        {

            var updatedCoordinates = _coordinateService.ExecuteCommand(currentCoordinates);

            return updatedCoordinates;
        } 
    }

    
}

