using PatternAdapterLib;
using System.Text;

namespace PatternAdapter
{
    internal class ShippingReportTextFormatter
    {
        public ShippingReport ShippingReport { get; }
        public string Summary { get; }

        public ShippingReportTextFormatter(ShippingReport report) {
            StringBuilder @string = new StringBuilder()
              .AppendLine("Name of carrier: " + report.Name)
              .AppendLine("Speed of carrier: " + report.SpeedOfTrasport)
              .AppendLine("Length of route: " + report.RouteLength)
              .AppendLine("Path include " + report.RoutePoints.Count() + " locations: ");
            foreach (Location location in report.RoutePoints) {
                @string.AppendLine($"{location.Latitude} {location.Longitude}");
            }

            ShippingReport = report;
            Summary = @string.ToString();
        }

        public override string ToString() => Summary;
    }
}
