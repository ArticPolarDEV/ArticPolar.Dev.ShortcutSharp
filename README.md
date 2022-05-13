# ShortcutSharp
Create and Delete Shortcut on Desktop
# Usage: 
````
using System;
using ShortcutSharp;

namespace myConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ShortcutSharp.Functions.CreateShortcut("name\of\app", @"path\to\icon.ico", @"executable\path, "description", @"working\directory");
            Console.ReadKey();
        }
    }
}
````
