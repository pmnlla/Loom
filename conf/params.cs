using System;
using System.Collections.Generic;

namespace Loom
{
    public class Mod
    {
        public string Url {get; set;}
        public string Name {get; set;}
        public bool Use {get; set;}
    }
    public class NoUrl
    {
        public struct Values
        {
            public string Url;
            public bool Use;
        }
    }
}