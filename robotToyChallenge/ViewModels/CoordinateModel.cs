using System;
namespace robotToyChallenge.ViewModels
{
    public class CoordinateModel
    {

        public CoordinateModel(string command, int xCoordinate, int yCoordinate, string facing)
        {
            Command = command;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Facing = facing;
        }

        public string Command { get; }
        public int XCoordinate { get; }
        public int YCoordinate { get; }
        public string Facing { get; }

    }
}
