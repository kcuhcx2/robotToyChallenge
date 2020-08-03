using System;
namespace robotToyChallenge.ViewModels
{
    public class UpdateCoordinateModel
    {
        public bool Success { get; }

        public UpdateCoordinateModel(bool success)
        {
            Success = success;
        }
    }
}
