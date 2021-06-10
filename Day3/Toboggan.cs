namespace Day3
{
    public class Toboggan
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public int Collisions { get; private set; }

        public Map Map { get; private set; }

        public Toboggan() : this(0, 0, new Map())
        {
        }

        public Toboggan(Map map) : this(0, 0, map)
        {
        }

        public Toboggan(int x, int y, Map map)
        {
            X = x;
            Y = y;

            Map = map;
        }

        private void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void Sled(int dx, int dy)
        {
            while(Y < Map.Height)
            {
                if(Map.GetObstacle(X, Y) == '#')
                {
                    Collisions++;
                }

                Move(dx, dy);
            }
        }
    }
}
