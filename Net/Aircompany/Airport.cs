using Aircompany.Models;
using Aircompany.Planes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        private List<Plane> planes;

        public Airport(IEnumerable<Plane> planes)
        {
            this.planes = planes.ToList();
        }

        public List<PassengerPlane> GetPassengersPlanes()
        {   
            return planes.Where(plane => plane is PassengerPlane).Select(plane=>plane as PassengerPlane).ToList();
        }

        public List<MilitaryPlane> GetMilitaryPlanes()
        {
            return planes.Where(plane => plane is MilitaryPlane).Select(plane => plane as MilitaryPlane).ToList();
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return GetPassengersPlanes().OrderBy(plane => plane.PassengersCapacityIs()).FirstOrDefault();
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return GetMilitaryPlanes().Where(militaryPlane=> militaryPlane.MilitaryPlaneType == MilitaryPlaneType.Transport).ToList();
        }

        public Airport SortPlanesByMaxDistance()
        {
            return new Airport(planes.OrderBy(plane => plane.MaxFlightDistance));
        }

        public Airport SortPlanesByMaxSpeed()
        {
            return new Airport(planes.OrderBy(plane => plane.MaxSpeed));
        }

        public Airport SortPlanesByMaxLoadCapacity()
        {
            return new Airport(planes.OrderBy(plane => plane.MaxLoadCapacity));
        }


        public IEnumerable<Plane> GetPlanes()
        {
            return planes;
        }

        public override string ToString()
        {
            return "Airport{" +
                    "planes=" + string.Join(", ", planes.Select(plane => plane.Model)) +
                    '}';
        }
    }
}
