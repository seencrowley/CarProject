using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject
{
    class Budget
    {
        public int savings;

        public Budget(int aSavings)
        {
            savings = aSavings;
        }

        public bool hasEnoughMoney(Car car)
        {
            if (savings >= car.price)
            {
                return true;
            }
            return false; 
        }
    }
}
