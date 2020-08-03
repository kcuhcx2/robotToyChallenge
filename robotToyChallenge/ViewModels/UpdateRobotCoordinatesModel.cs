using System;
using System.Collections.Generic;

namespace robotToyChallenge.ViewModels
{
    public class UpdateRobotCoordinatesModel
    {

        public bool CanUpdateRobotCoordinate { get; }
        public IEnumerable<string> ValidationMessages { get;  }

        public UpdateRobotCoordinatesModel(bool canUpdateRobotCoordinate, IEnumerable<string> validationMessages)
        {
            CanUpdateRobotCoordinate = canUpdateRobotCoordinate;
            ValidationMessages = validationMessages;
        }
    }
}
