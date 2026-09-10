using System;
using System.Collections.Generic;
using System.IO;

string? PathFile;

Console.WriteLine("CSV Reader");

while (true)
{
    Console.Write("File Path: ");
    PathFile = Console.ReadLine();
    // Null Dealing
    if (PathFile == null)
    {
        Console.WriteLine("Invalid. Try again: ");
    }

    // File Validation
    if (File.Exists(PathFile))
    {
        break;
    }
    else
    {
        Console.WriteLine("File not Found! Try again: ");
    }
}

Console.WriteLine("File Exists!");

// Menu
Console.Clear();
Console.WriteLine("Main Menu");
Console.WriteLine("1. Read File");
Console.WriteLine("2. Find and Read Columns");
Console.WriteLine("3. Edit a Cell");
Console.WriteLine("4. Quit Program");
MainMenu();

// Functions according to Selection
static void ReadFile(string FilePath)
{
    
}

static void MainMenu()
{
    int selNum;
    while (true)
    {
        Console.Write("Select Option: ");
        string selection = Console.ReadLine();
        if (!int.TryParse(selection, out selNum))
        {
            Console.Write("Invalid Selection! Try again: ");
            selection = Console.ReadLine();
        }
        else
        {
            break;
        }
    }

    switch (selNum)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            Console.WriteLine("Exiting Program. Thank You.");
            break;
    }
}