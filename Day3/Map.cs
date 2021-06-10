using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day3
{
    public class Map
    {
        private List<char[]> grid = new List<char[]>();

        public int Height { get; private set; }

        public Map()
        {
            GenerateMap();

            Height = grid.Count();
        }

        private void GenerateMap()
        {
            var tr = new StreamReader(@"input.txt");
            
            string line;
            while ((line = tr.ReadLine()) != null)
            {
                grid.Add(line.ToCharArray());
            }

            tr.Close();
        }

        public char GetObstacle(int x, int y)
        {
            var relativeX = x % grid[y].Length;
            return grid[y][relativeX];
        }
    }
}
