﻿using BoundarySeparationProject.EncryptionLayer;
using BoundarySeparationProject.InputLayer;
using BoundarySeparationProject.OutputLayer;

namespace BoundarySeparationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var encrypter = new MessageEncrypter(new ConsoleReader(), new ConsoleWriter());

            bool isEmptyLine;

            do
            {
                isEmptyLine = encrypter.EncryptMessage();
            }
            while (!isEmptyLine);
        }
    }
}
