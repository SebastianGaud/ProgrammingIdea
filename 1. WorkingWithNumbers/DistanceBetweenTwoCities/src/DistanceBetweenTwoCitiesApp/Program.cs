using System;
using DistanceBetweenTwoCitiesLib;

namespace DistanceBetweenTwoCitiesApp
{
    class Program
    {
        static void Main(string[] args)
        {
           City city1 = new City(CreateNewCoordinate());
           City city2 = new City(CreateNewCoordinate());

           Console.WriteLine("Distance between two cities is:" + city1.CalculateDistanceFromAnotherCityInKM(city2)+ " KM");
        }

        private static Coordinate CreateNewCoordinate()
        {
            
            double latitude, longitude;
            Console.WriteLine("Insert Latitude:");
            if(Double.TryParse(Console.ReadLine(), out latitude)){
                Console.WriteLine("Okay, move on");
            }
            else
            {
                Console.WriteLine("Coordinate can be only numeric value!");
            }

            Console.WriteLine("Insert Longitude: ");
            if(Double.TryParse(Console.ReadLine(), out longitude)){
                Console.WriteLine("Okay, move on");
            }
            else
            {
                Console.WriteLine("Coordinate can be only numeric value!");
            }

            return new Coordinate(latitude, longitude);
        }
    }
}
