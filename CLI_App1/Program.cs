using System;
using System.Collections.Generic;
using System.IO;

string PathFile;
Console.WriteLine("CSV Reader");

while (true)
{
    Console.Write("File Path: ");
    PathFile = Console.ReadLine();

    // File Validation
    if (File.Exists(PathFile)) break;

    Console.WriteLine("File not Found!");
}

Console.Write("File Exists!");
