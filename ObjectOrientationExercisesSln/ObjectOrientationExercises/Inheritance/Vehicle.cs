using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationExercises.Inheritance
{
    internal class Vehicle
    {

        public string Color { get; set; }



       /* private string color = string.Empty;

        public string Color
        {
            set
            {
                color = value;
            }

            get { 
                return color; 
            }


        }*/

        public int CurrentSpeed
        {
            set
            {
                if (value > TopSpeed)
                    currentSpeed = TopSpeed;
                else
                    currentSpeed = value;

            }

            get
            {
                return currentSpeed;
            }


        }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
       
        public int NumEngines { get; set; }

        public int TopSpeed { get; set; }

        public int NumOfSeats { get; set; }

        public int NumDrivers { get; set; }

        private int currentSpeed = 0;


        public Vehicle(string make, string model, int year, int topSpeed)
        {
            Make = make;
            Model = model;
            Year = year;
            TopSpeed = topSpeed;
        }

       /* public string GetMake()
        {
            return make;
        }

        public void SetMake(string make)
        {
            this.make = make;
        }
       */
        public void SetCurrentSpeed(int speed)
        {
            if (speed > TopSpeed)
            currentSpeed = TopSpeed;
        }
       /* public string GetModel()
        {
            return model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        */
       /* public int GetTopSpeed()
        {
            return topSpeed;
        }

        public void SetTopSpeed(int topSpeed)
        {
            this.topSpeed = topSpeed;
        }
       */
        public virtual void DisplayDescription()
        {
            Console.WriteLine($"Vehicle:  Make: {Make}, Model: {Model}, Year: {Year}  ");
        }

    }
}

