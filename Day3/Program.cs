using System;

namespace Day3
{
    class Program
    {
        // https://adventofcode.com/2020/day/3
        static void Main(string[] args)
        {
            // Part 1
            Toboggan toboggan1 = new Toboggan();
            toboggan1.Sled(3, 1);

            Console.WriteLine(toboggan1.Collisions);

            // Part 2
            var collisionsMultiple = 0;

            Map map = new Map();

            Toboggan toboggan = new Toboggan(map);
            toboggan.Sled(1, 1);
            collisionsMultiple = toboggan.Collisions;

            toboggan = new Toboggan(map);
            toboggan.Sled(3, 1);
            collisionsMultiple *= toboggan.Collisions;

            toboggan = new Toboggan(map);
            toboggan.Sled(5, 1);
            collisionsMultiple *= toboggan.Collisions;

            toboggan = new Toboggan(map);
            toboggan.Sled(7, 1);
            collisionsMultiple *= toboggan.Collisions;

            toboggan = new Toboggan(map);
            toboggan.Sled(1, 2);
            collisionsMultiple *= toboggan.Collisions;

            Console.WriteLine(collisionsMultiple);
        }
    }
}
