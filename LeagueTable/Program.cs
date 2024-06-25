using System;

namespace LeagueTable
{
    class Program
    {
        static void Main(string[] args)
        {
            TableRow liverpool = new("Liverpool", 0, 0, 0, 0, 0, 0);
            TableRow arsenal = new("Arsenal London", 2, 0, 1, 0, 0, 3);
            Console.WriteLine(
                $"{"Team", 20} {"#", 2} {"W", 2} {"D", 2} {"T", 2} {"+", 2} {"-", 2} {"=", 2} {"P", 2}"
            );
            Console.WriteLine(liverpool);
            Console.WriteLine(arsenal);
        }
    }
}
