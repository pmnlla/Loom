using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows;
// using System.Windows.Forms;
using System.Linq;

namespace Loom
{    
    public partial class Sys{
        public string[] ver;
        public string dist = "";
        public string dir = "";
        
        public void DetectParams(bool output){
            // detect OS version
            dist = Environment.OSVersion.ToString();
            ver = dist.Split(' ');

            if(ver[0] == "Unix"){ ver[0] = "Linux"; }
            if(output == true) {
                Console.WriteLine(@"I> Running on {0}, kernel {1}", ver[0], ver[1]);

                Console.WriteLine("---------------------");
                getTargetDir();
            }
        }

        public void getTargetDir(){
            if (ver[0] == "Microsoft"){
                dir = (System.Environment.GetEnvironmentVariable("USERPROFILE").ToString() + "/AppData/Roaming/.minecraft");
            } else if (ver[0] == "Linux"){
                dir = (System.Environment.GetEnvironmentVariable("HOME").ToString() + "/.minecraft"); // $HOME being the linux equivilent of %USERPROFILE%.
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

                // check if the fabric modloader is installed
                // this is a very shitty way to do it. in reality, what should be done is ensuring that the remappedJars folder exists,
                // and if it does, we need to parse the name for every single file to extract the fabric version and minecraft version.
                // we need to do it this way in order to ensure that no version number change will make it so that this test isn't passed,
                // and ideally we should be getting the version numbers from Fabric's and Mojang's (dead corpse's) servers respectively.
                
                if(Directory.Exists(dir + ".fabric")){
                    Console.WriteLine("I> Fabric modloader detected! Verifying latest version is installed...");
                    if(File.Exists(dir + ".fabric/remappedJars/minecraft-1.18.1-0.12.12")){
                        Console.WriteLine("I> Latest version installed!");
                    }
                    else{
                        Console.WriteLine("E> Please install Fabric version 0.12.12 for Minecraft 1.18.1");
                    }
                }
                else
                {
                    Console.WriteLine("E> Fabric not found! Please install Fabric version 0.12.12 for Minecraft 1.18.1");
                }
            } else {
                Console.WriteLine("E> Unable to find Minecraft directory at {0}", dir);
            }
        }
    }
}