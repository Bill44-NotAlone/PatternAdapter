namespace PatternAdapterLib
{
    public class Location
    {
        public int Longitude { get; set; }
        public int Latitude { get; set; }

        public static Location Create(int longitude, int latitude)
        {
            Location location = new Location();
            location.Longitude = longitude;
            location.Latitude = latitude;
            return location;
        }
    }
}
