using System;

namespace BoundarySeparationProject
{
    class ConsoleWriter : ILineWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine($"Encrypted value: {line}");
        }
    }
}
