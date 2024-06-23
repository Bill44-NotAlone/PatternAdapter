namespace PatternAdapterLib.Transport
{
    public class Superjet : IAirplane
    {
        private bool requiredHeight;
        private int speed;
        private int height;
        private const int REQUIRED_HEIGHT = 9000;
        private const int MAX_SPEED = 926;

        public int Speed { get => speed; set => speed = value; }

        public void Fly()
        {
            if (requiredHeight)
            {
                Speed = Speed + 2;
                height = height + 32;
                requiredHeight = REQUIRED_HEIGHT <= height;
            } else {
                if (MAX_SPEED < Speed) return;

                Speed = Speed + 100;
            }
        }
    }
}
