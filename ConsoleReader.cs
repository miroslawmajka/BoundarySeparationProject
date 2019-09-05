﻿using System;

namespace BoundarySeparationProject.InputLayer
{
    class ConsoleReader : ILineReader
    {
        public string ReadLine()
        {
            Console.Write("Enter value to encrypt (empty to end program): ");

            return Console.ReadLine();
        }
    }
}
