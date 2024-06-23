namespace PatternAdapterLib.Еransport
{
    public interface ICar
    {
        string Name { get; }
        int Speed { get; }

        int IncreaseSpeed();
    }
}
