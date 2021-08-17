using System;
using Codecool.CarRace.Util;

namespace Codecool.CarRace.Vehicles
{
    /// <summary>
    /// Motorcycle
    /// </summary>
    public class Motorcycle : Vehicle
    {
        /// <summary>
        /// The speed in good weather conditions.
        /// </summary>
        private const int NORMAL_SPEED = 100;

        /// <summary>
        /// Motorcycles have names with serial numbers.  We have to track
        /// the numbering on a class level that's why this field is static.
        /// </summary>
        private static int _motorcycleNumber = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="Motorcycle"/> class.
        /// </summary>
        public Motorcycle()
            : base(NORMAL_SPEED)
        {
        }

        /// <summary>
        /// Motorcycles go with their normal speed. In case of rain they
        /// have to slow down.
        /// </summary>
        /// <param name="race">instance of the current race from where we can access data
        /// for example weather conditions and broken truck info
        /// </param>
        public override void PrepareForLap(Race race)
        {
            ActualSpeed = NORMAL_SPEED;

            if (race.IsRaining)
            {
                int slowDown = RandomHelper.NextInt(5, 50 + 1);
                ActualSpeed -= slowDown;
            }
        }

        /// <summary>
        /// mc
        /// </summary>
        protected override string GenerateName()
        {
            return "Motorcycle " + _motorcycleNumber++;
        }
    }
}
