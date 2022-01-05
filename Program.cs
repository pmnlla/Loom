// No, I won't be using the new C# templates for dotnet 6. C# is not a scripting language.
// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

using Checkbox;
namespace Loom // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static string[] opts;
        public static void Main(string[] args) // A classic.
        {
            Console.WriteLine("Welcome to Loom!");
            var OS = new Loom.Sys();
            OS.DetectParams();
            Checklist();
            // OS.dlmod("","");
        } 
        public static void Checklist(){

            var OS = new Loom.Sys();
            OS.PopulateArray();

            string title = "Please select the mods you would like to install: \n";
            for (int i = 0; i > OS.modlist.Count; i++){
                //opts[i] = 
                Console.WriteLine(OS.modlist);
            }
            /*
            var cbox = new Checkbox.Checkbox(title, opts);
            var output = cbox.Select();
            Console.Write(Environment.NewLine + @output);
            */
        }
    }
}