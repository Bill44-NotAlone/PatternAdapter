using PatternAdapterLib.Еransport;

namespace PatternAdapterLib
{
    public class Route
    {
        private ICar carrier;
        private Location APoint;
        private Location BPoint;

        public Route(ICar car, Location aPoint, Location bPoint)
        {
            this.carrier = car;
            this.APoint = aPoint;
            this.BPoint = bPoint;
        }

        public ShippingReport Start()
        {
            int length = CalculatePathLength();
            int distanceTraveled = 0;

            while (true)
            {
                if (length <= distanceTraveled)
                {
                    return ShippingReport.Of(carrier, length, APoint, BPoint);
                }
                else
                {
                    int speed = carrier.IncreaseSpeed();
                    distanceTraveled = distanceTraveled + speed;
                }
            }
        }

        private int CalculatePathLength() 
        {
            Location a = APoint;
            Location b = BPoint;

            if (a.Latitude == b.Latitude && a.Longitude == b.Longitude) return 0;

            double length = Math.Sqrt(Math.Pow(b.Latitude - a.Latitude, 2) + Math.Pow(b.Longitude - a.Longitude, 2));

            return (int) length;
        }
    }
}
