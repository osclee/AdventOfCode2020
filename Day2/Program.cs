using System;
using System.Collections.Generic;
using System.IO;

namespace Day2
{
    class Program
    {
        // https://adventofcode.com/2020/day/2
        static void Main(string[] args)
        {
            var rawPasswords = new List<string>();

            var tr = new StreamReader(@"input.txt");

            string line;
            while ((line = tr.ReadLine()) != null)
                rawPasswords.Add(line);

            var validPasswords = 0;
            foreach (var rawPassword in rawPasswords)
                if (Part2(rawPassword)) validPasswords++;

            Console.WriteLine(validPasswords);
        }

        static bool Part1(string line)
        {
            char[] delims = { ' ', ':', '-' };
            var words = line.Split(delims, StringSplitOptions.RemoveEmptyEntries);

            var count = 0;
            foreach(var character in words[3].ToCharArray())
                if (character == words[2].ToCharArray()[0]) count++;

            if (count >= int.Parse(words[0]) && count <= int.Parse(words[1])) return true;

            return false;
        } 

        // 360
        static bool Part2(string line)
        {
            char[] delims = { ' ', ':', '-' };
            var words = line.Split(delims, StringSplitOptions.RemoveEmptyEntries);

            var pos1 = int.Parse(words[0]) - 1;
            var pos2 = int.Parse(words[1]) - 1;

            var letters = words[3].ToCharArray();
            var letter = char.Parse(words[2]);

            return (letters[pos1] == letter) ^ (letters[pos2] == letter);
        }
    }
}
