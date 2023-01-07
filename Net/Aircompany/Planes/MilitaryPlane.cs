using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        private MilitaryPlaneType militaryPlaneType;

        public MilitaryPlane(
            string model,
            int maxSpeed,
            int maxFlightDistance,
            int maxLoadCapacity,
            MilitaryPlaneType type)
            : base(
                  model, 
                  maxSpeed, 
                  maxFlightDistance,
                  maxLoadCapacity)
        {
            this.MilitaryPlaneType = type;
        }

        public MilitaryPlaneType MilitaryPlaneType { get => militaryPlaneType; set => militaryPlaneType = value; }

        public override bool Equals(object obj)
        {
            if (obj is MilitaryPlane plane)
            {
                return base.Equals(obj) && MilitaryPlaneType == plane.MilitaryPlaneType;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + MilitaryPlaneType.GetHashCode();
            return hashCode;
        }



        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + MilitaryPlaneType +
                    '}');
        }        
    }
}
