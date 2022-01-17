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
        public static string[] opts = {};
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

            string title = "Please select the mods you would like to install. \nPlease do note that mods found on CurseForge and not Modrinth are unavailable due to the way that Curseforge's CDN works. \nNONE OF THE MODS INSTALL AUTOMATICALLY AT THE MOMENT.";
            // for (int i = 0; i > OS.modlist.Count; i++){
            int i = 0;
            foreach (modProperties mod in OS.modlist){
                try{
                    opts[i] = mod.Name;
                }
                catch (Exception e){
                    Array.Resize(ref opts, opts.Length + 1);
                    opts[i] = mod.Name;
                }
                //Console.WriteLine();
                i++;
            }
            var cbox = new Checkbox.Checkbox(title, true, false, opts);
            var output = cbox.Select();

            foreach(var returnValue in output){
                Console.Write(@returnValue.Index + " " + @returnValue.Option + Environment.NewLine);

                OS.modlist[returnValue.Index].Use = true;
            }
            // debugging
            foreach (modProperties mod in OS.modlist){
                Console.Write(@mod.Use + Environment.NewLine);
            }
            
        }
    }
}