using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows;
// using System.Windows.Forms;
using System.Linq;

namespace Loom
{    
    public class Sys{
        public string[] ver;
        public string dist = "";
        public string dir = "";
        
        public void DetectParams(){
            // detect OS version
            dist = Environment.OSVersion.ToString();
            ver = dist.Split(' ');

            if(ver[0] == "Unix"){ ver[0] = "Linux"; }

            Console.WriteLine(@"I> Running on {0}, kernel {1}", ver[0], ver[1]);

            Console.WriteLine("---------------------");
            getTargetDir();
        }

        public void getTargetDir(){
            if (ver[0] == "Microsoft"){
                dir = (System.Environment.GetEnvironmentVariable("USERPROFILE").ToString() + "/AppData/Roaming/.minecraft");
            } else if (ver[0] == "Linux"){
                dir = "$HOME/.minecraft"; // $HOME being the linux equivilent of %USERPROFILE%.
            }
            
            // simple checks to ensure that the directories exist
            if(Directory.Exists(dir)){
                Console.WriteLine("Found Minecraft directory!");
                if(Directory.Exists(dir + "/mods")){
                    Console.WriteLine("I> Found mods directory!");
                    Console.Beep();
                } else {
                    Console.WriteLine("E> Unable to find mods directory!");
                }
            } else {
                Console.WriteLine("E< Unable to find Minecraft directory!");
            }
        }
    }
}