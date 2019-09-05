using System;

namespace BoundarySeparationProject.OutputLayer
{
    class ConsoleWriter : ILineWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine($"Encrypted value: {line}");
        }
    }
}
