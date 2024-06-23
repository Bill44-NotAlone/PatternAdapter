using PatternAdapterLib.Еransport;

namespace PatternAdapterLib
{
    public class ShippingReport
    {
        public string Name { get; }
        public int SpeedOfTrasport { get; }
        public int RouteLength { get; }
        public IEnumerable<Location> RoutePoints { get; }

        private ShippingReport(ICar carrier, int length, IEnumerable<Location> points) 
        {
            Name = carrier.Name;
            SpeedOfTrasport = carrier.Speed;
            RouteLength = length;
            RoutePoints = points;
        }

        internal static ShippingReport Of(ICar carrier, int routeLength, params Location[] routePoints)
        {
            IEnumerable<Location> points = routePoints.AsEnumerable();
            return new ShippingReport(carrier, routeLength, points);
        }
    }
}
