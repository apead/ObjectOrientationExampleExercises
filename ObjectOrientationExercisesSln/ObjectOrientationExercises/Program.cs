using ObjectOrientationExercises.Abstraction;
using ObjectOrientationExercises.Inheritance;
using System.Net.Http.Headers;

namespace ObjectOrientationExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*   Boat boat = new Boat("FancyBoat", "zx", 2000, 60, true, 10);

            boat.CurrentSpeed = 400;

           
            int exampleSpeed = boat.CurrentSpeed;

            MilitaryPlane sr71 = new MilitaryPlane("Lokheed", "sr71", 1980, 3000, 2, true, 0, 4);



            sr71.CurrentSpeed = 5000;

            */

            Animal dog = new Dog();
            //dog.MakeNoise();

            Animal cat = new WildCat();
           // cat.MakeNoise();

            Animal bird = new Eagle();
           // bird.MakeNoise();

         

            List<Animal> zoo = new List<Animal>();
            zoo.Add(bird);
            zoo.Add(cat);
            zoo.Add(dog);

;           // bob.MakeNoise();

            foreach(Animal animal in zoo)
            {
               
                
                animal.MakeNoise();
            }

           /* List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square(15));
            shapes.Add(new Circle(25));
            shapes.Add(new Rectangle(20,25));


            foreach(Shape shape in shapes)
            {
               double area = shape.GetArea();

               Console.WriteLine($" {shape.GetShapeName()} area is {area}");

            }
           */



            
            
            /*
            Vehicle demoVehicle = new Vehicle("Mazda", "CX5", 2021, 220);


            demoVehicle.CurrentSpeed = 400;

            int myCurrentSpeed = demoVehicle.CurrentSpeed;
           
            demoVehicle.Color = "Red";

            string myColor = demoVehicle.Color;

            Console.WriteLine(demoVehicle.Color);

            Vehicle myBoat = new Boat("Yamaha", "Duck", 2012, 60,true, 3000, 32);
            myBoat.DisplayDescription();


            Vehicle myPlane = new Plane("Boeing", "747", 1974, 750, 2, true, 1);
            myPlane.DisplayDescription();

            Vehicle myTopGunPlane = new MilitaryPlane("TopCat", "F14", 1980, 1000, 2, true, 1, 3);
            myTopGunPlane.DisplayDescription();
            
            */
            /*
             * Just an exampe to answer question on how would this work from the keyboard as user input
             * 
             * string carMake = Console.ReadLine();
              string carModel = Console.ReadLine();
              string carYear = Console.ReadLine();
              string topSpeed = Console.ReadLine();

              Vehicle demoVehicle = new Vehicle(carMake, carModel, int.Parse(carYear), int.Parse(topSpeed));

              demoVehicle.Color = "Red";

              Console.WriteLine(demoVehicle.Color);

              carMake = Console.ReadLine();
              carModel = Console.ReadLine();
              carYear = Console.ReadLine();
              topSpeed = Console.ReadLine();

              Vehicle anotherVehicle = new Vehicle(carMake, carModel, int.Parse(carYear), int.Parse(topSpeed));
            */
        }
    }
}
