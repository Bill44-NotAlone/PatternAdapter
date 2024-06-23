using PatternAdapterLib.Transport;
using PatternAdapterLib.Еransport;

namespace PatternAdapterLib.Adapter
{
    public class AirplaneToCarAdapter : ICar
    {
        private IAirplane airplane;

        public AirplaneToCarAdapter(IAirplane adaptable) 
        {
            this.airplane = adaptable;
        }

        public int Speed => airplane.Speed;

        public string Name => "Airplane";

        public int IncreaseSpeed()
        {
            airplane.Fly();
            return this.Speed;
        }

        public static AirplaneToCarAdapter Of(IAirplane adaptable) 
        {
            return new AirplaneToCarAdapter(adaptable);
        }
    }
}
