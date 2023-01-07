using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        private string model;
        private int maxSpeed;
        private int maxFlightDistance1;
        private int maxLoadCapacity1;

        public string Model { get => model; set => model = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public int MaxFlightDistance { get => maxFlightDistance1; set => maxFlightDistance1 = value; }
        public int MaxLoadCapacity { get => maxLoadCapacity1; set => maxLoadCapacity1 = value; }

        public Plane(
            string model,
            int maxSpeed,
            int maxFlightDistance,
            int maxLoadCapacity)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            MaxFlightDistance = maxFlightDistance;
            MaxLoadCapacity = maxLoadCapacity;
        }


        public override string ToString()
        {
            return "Plane{" +
                "model='" + Model + '\'' +
                ", maxSpeed=" + MaxSpeed +
                ", maxFlightDistance=" + MaxFlightDistance +
                ", maxLoadCapacity=" + MaxLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            if(obj is Plane plane)
            {
                return Model == plane.Model &&
                       MaxSpeed == plane.MaxSpeed &&
                       MaxFlightDistance == plane.MaxFlightDistance &&
                       MaxLoadCapacity == plane.MaxLoadCapacity;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * -1521134295 + MaxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxLoadCapacity.GetHashCode();
            return hashCode;
        }        
    }
}
