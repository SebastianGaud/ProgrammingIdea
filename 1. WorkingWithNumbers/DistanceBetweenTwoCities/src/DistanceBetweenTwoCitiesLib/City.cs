using System;

namespace DistanceBetweenTwoCitiesLib
{
    public class City
    {
        public Coordinate Coordinate { get; set; }

        public City(Coordinate coordinate)
        {
            this.Coordinate = coordinate;
        }

        public double CalculateDistanceFromAnotherCityInKM(City city){

            double degreesLongitude = (city.Coordinate.Longitude - this.Coordinate.Longitude) * Coordinate._DegreesToRadiansConstant; 
            double degreesLatitude = (city.Coordinate.Latitude - this.Coordinate.Latitude) * Coordinate._DegreesToRadiansConstant;
            double a = Math.Pow(Math.Sin(degreesLatitude / 2D), 2D) 
                     + Math.Cos(this.Coordinate.Latitude * Coordinate._DegreesToRadiansConstant) 
                     * Math.Cos(city.Coordinate.Latitude * Coordinate._DegreesToRadiansConstant) 
                     * Math.Pow(Math.Sin(degreesLongitude / 2D), 2D);
            double c = 2D * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1D - a));
            double d = Coordinate._EquatorialEarthRadius * c;

            return d;
        }
    }
}