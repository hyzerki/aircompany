using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int passengersCapacity;

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
            this.passengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            if(obj is PassengerPlane plane)
            {
                return base.Equals(obj) && passengersCapacity == plane.passengersCapacity;
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
            hashCode = hashCode * -1521134295 + passengersCapacity.GetHashCode();
            return hashCode;
        }

        public int PassengersCapacityIs()
        {
            return passengersCapacity;
        }

       
        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + passengersCapacity +
                    '}');
        }       
        
    }
}
