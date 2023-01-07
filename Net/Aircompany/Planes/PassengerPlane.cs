using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        private int passengersCapacity;

        public PassengerPlane(
            string model,
            int maxSpeed,
            int maxFlightDistance,
            int maxLoadCapacity,
            int passengersCapacity)
                :base(model,
                     maxSpeed,
                     maxFlightDistance, maxLoadCapacity)
        {
            this.PassengersCapacity = passengersCapacity;
        }

        public int PassengersCapacity { get => passengersCapacity; set => passengersCapacity = value; }

        public override bool Equals(object obj)
        {
            if(obj is PassengerPlane plane)
            {
                return base.Equals(obj) && PassengersCapacity == plane.PassengersCapacity;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + PassengersCapacity.GetHashCode();
            return hashCode;
        }

       
        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + PassengersCapacity +
                    '}');
        }       
        
    }
}
