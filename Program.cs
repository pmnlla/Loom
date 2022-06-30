// No, I won't be using the new C# templates for dotnet 6. C# is not a scripting language.
// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

using Phosphorus;

namespace Phosphorus // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static string[] opts = {};
        public static void Main(string[] args) // A classic.
        {
            // start tthis shit
            Console.WriteLine("phosphorus amogus");
            
            var OS = new Phosphorus.Sys();
            OS.DetectParams();
            OS.PopulateArray();

            mainWindow win = new mainWindow();
            win.init(OS);
        }
    }
}