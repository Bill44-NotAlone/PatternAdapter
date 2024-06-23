using PatternAdapterLib.Еransport;

namespace PatternAdapterLib.Transport
{
    public class Jeep : ICar
    {
        public int Speed { get; set; }
        public string Name => "Jeep";


        public const int MAX_SPEED = 210; 

        public int IncreaseSpeed()
        {
            if (Speed > MAX_SPEED) return MAX_SPEED;
            return Speed = Speed + 2;
        }
    }
}
