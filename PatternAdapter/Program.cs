using PatternAdapter;
using PatternAdapterLib;
using PatternAdapterLib.Adapter;
using PatternAdapterLib.Transport;
using PatternAdapterLib.Еransport;

public class Program
{
    private static void Main(string[] args)
    {
        Location a = Location.Create(13, 56);
        Location b = Location.Create(20014, 31345);

        ICar jeep = new Jeep();
        IAirplane airplane = new Superjet();
        ICar airplaneAdapter = AirplaneToCarAdapter.Of(airplane);

        Route realCarRoute = new Route(jeep, a, b);
        Route adapterCarRoute = new Route(airplaneAdapter, a, b);

        List<Route> routes = new List<Route> { realCarRoute, adapterCarRoute };

        foreach (Route route in routes) {
            ShippingReport report = route.Start();
            ShippingReportTextFormatter formatter = new ShippingReportTextFormatter(report);
            Console.WriteLine(formatter);
        }
    }
}