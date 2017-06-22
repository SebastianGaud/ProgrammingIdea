namespace DistanceBetweenTwoCitiesLib
{
    public class Coordinate
    {
        public readonly static double _DegreesToRadiansConstant = (System.Math.PI / 180D);
        public static readonly double _EquatorialEarthRadius = 6378.1370D;

        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Coordinate(double longitude, double latitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public static double ConvertDistanceInKM(double distance){
            return distance * 1000D;
        }
    }
}