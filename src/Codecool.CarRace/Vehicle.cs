using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.CarRace.Vehicles
{
    /// <summary>
    ///  Vehicle
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class.
        /// </summary>
        protected Vehicle(int normalSpeed)
        {
            Name = GenerateName();
            NormalSpeed = normalSpeed;
        }

        /// <summary>
        /// Child classes should implement naming inside this method
        /// <returns>a good name for the vehicle.</returns>
        /// </summary>
        protected abstract string GenerateName();

        /// <summary>
        /// NormalSpeed
        /// </summary>
        protected readonly int NormalSpeed;

        /// <summary>
        /// Name
        /// </summary>
        protected readonly string Name;

        /// <summary>
        /// ActualSpeed
        /// </summary>

        protected int ActualSpeed;

        /// <summary>
        /// DistanceTravelled
        /// </summary>
        protected int DistanceTravelled;

        /// <summary>
        /// PrepareForLooop
        /// </summary>
        public abstract void PrepareForLap(Race race);

        /// <summary>
        /// MoveForAnHour
        /// </summary>
        public void MoveForAnHour()
        {
            DistanceTravelled += ActualSpeed;
        }

        /// <summary>
        /// The textual representation of this vehicle.
        /// </summary>
        /// <returns>The textual representation of this vehicle</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("{type: ")
            .Append(GetType().Name)
            .Append(", ")
            .Append("name: ")
            .Append(Name)
            .Append(", ")
            .Append("distance travelled: ")
            .Append(DistanceTravelled)
            .Append("}");
            return sb.ToString();
        }

        private static int _motorcycleNumber = 1;
    }
}
