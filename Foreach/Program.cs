using System;

namespace Foreach
{
    class Foreach
    {
        static void Main(string[] args)
        {
            string[] team = {"佐藤", "鈴木", "田中", "岸田", "有森"};

            foreach (var name in team)
            {
                Console.WriteLine(name + "さん");
            }
        }
    }
}
