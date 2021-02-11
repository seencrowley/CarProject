using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject
{
    class Dealership
    {
        List<Car> _parkinglot = new List<Car>();

        public void AddToMyParkignLot(Car car)
        {
            _parkinglot.Add(car);
        }
    }
}
