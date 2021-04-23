﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleWriting
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var count = 0;

            while (true)
            {
                Console.WriteLine($"Hello World! - {count}");
                await File.AppendAllTextAsync("WriteLines.txt", "Hello World!" + Environment.NewLine);
                await Task.Delay(1000);
                count++;
                if (count == 30)
                    throw new Exception("TestException");
            }
        }
    }
}