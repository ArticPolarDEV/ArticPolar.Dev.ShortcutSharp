# ArticPolar.Dev.ShortcutSharp
Create and Delete Shortcut on Desktop

Nuget Package: [Here](https://www.nuget.org/packages/ArticPolar.Dev.ShortcutSharp)

# Usage:

## Create Shortcut 
````
using System;
using ArticPolar.Dev.ShortcutSharp;

namespace myConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ShortcutSharp.CreateShortcut("name\of\shortcut", @"path\to\icon.ico", @"executable\path, "description", @"working\directory");
            Console.ReadKey();
        }
    }
}
````

## Delete Shortcut
````
using System;
using ArticPolar.Dev.ShortcutSharp;

namespace myConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ShortcutSharp.DeleteShortcut("name\of\shortcut");
            Console.ReadKey();
        }
    }
}

````
