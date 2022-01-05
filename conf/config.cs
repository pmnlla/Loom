using System;
using System.Threading;
using System.Windows;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

using Loom;

namespace Loom
{
    public partial class Sys
    {
        // public Loom.Mod[] modlist = new Loom.Mod[]; // as of now, the only place I can store mod info in is a list. 
                                                       // Loom.Mod will be implemented in a later version.
        
        public List<Tuple<string, string, bool>> modlist = new List<Tuple<string,string,bool>>();
        public void PopulateArray(){
            string path = (Directory.GetCurrentDirectory() + "/config.json");

            Loom.Sys OS = new Loom.Sys();

            /* if (!File.Exists(path)){
                testVoid(); //TODO: replace this with something that downloads an actual config
            }*/

            // take json file and split each line into an entry in an array
            string input = File.ReadAllText(path);
            //Console.WriteLine(value);
            string[] value = input.Split(Environment.NewLine); 
            
            // parse the json
            for (int i = 0; i < (value.Length - 1); i++){
                // parse entry into dict
                Dictionary<string, string> unformattedList = JsonConvert.DeserializeObject<Dictionary<string, string>>(value[i]);
                Console.WriteLine(i.ToString());
                // take dict entries and put them in modlist dict
                // (string, bool) modMetadata = (unformattedList["Url"], Convert.ToBoolean(unformattedList["Use"]));
                var values = Tuple.Create(unformattedList["Name"], unformattedList["Url"], Convert.ToBoolean(unformattedList["Use"]));
                modlist.Add(values);
                /*
                modlist[(i+1)].Url = unformattedList["Url"];
                modlist[(i+1)].Name = unformattedList["Name"];
                modlist[(i+1)].Use = Convert.ToBoolean(unformattedList["Use"]);
                */
            }
        } 

        // what you will see below is an undocumented mess. this simply creates an example config file to work with while working on the parser.
        public void testVoid(){
            var mods = new Mod();
            string path = @"./config.json";
            string json = "";
            for(int i = 0; i < 5; i++){
                mods.Url = ("https://www.example.com");
                mods.Name = ("test" + i.ToString());
                mods.Use = true;
                json += (JsonConvert.SerializeObject(mods) + Environment.NewLine);
                 
            }
            Console.Write(path);
            File.AppendAllText(path, json);
        }

    }
}