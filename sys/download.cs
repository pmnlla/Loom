using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows;
using System.Linq;
using System.Net;
using System.IO;

namespace Loom
{
    public class Sys
    {
        public static void dlmod(string url){

            // make new webclient; `dlr` will be how we do web operations
            WebClient dlr = new WebClient();

            // add a user agent, because curseforge cdn is extrenely fucking stupid and cURL/wget don't work for some dumb fucking reason.
            // spigotmc does this too.
            // can you tell i hate the minecraft server administration and modding scenes? -pomonella01
            dlr.Headers.Add("user-agent", "Mozilla/5.0 (X11; Linux x86_64; rv:91.0) Gecko/20100101 Firefox/91.0");

            // actual download operations | https://docs.microsoft.com/en-us/dotnet/api/system.net.webclient?view=net-6.0 
            Stream data = dlr.OpenRead (url);
            


        }
    }
}