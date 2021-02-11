using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject
{
    public class Car
    {
        //make these properties (automatic properties) 
        private string maker;
        public string model;
        public int price;
        public int year;
        public string color;
        public string dealer;

        public Car(string aMaker, string aModel, int aPrice, int aYear, string aColor, string aDealer)
        {
            Maker = aMaker;
            model = aModel;
            price = aPrice;
            year = aYear;
            color = aColor;
            dealer = aDealer;
        } 

        public string Maker
        {
            get { return maker; }
            set {
                if (value == "Toyota" || value == "Audi" || value == "Volvo")
                {
                    maker = value; 
                }
                else
                {
                    maker = "We don't carry that maker's car";
                }
            } 
        }
    }
}
