using System;
using Phosphorus;
namespace Phosphorus.Utils{

    // https://stackoverflow.com/questions/630803/associating-enums-with-strings-in-c-sharp
    public class ErrPrefix
    {
        private ErrPrefix(string value) { Value = value; }

        public string Value { get; private set; }

        public static ErrPrefix Info    { get { return new ErrPrefix(@"\033[103m[WARN] \033[37m "); } }
        public static ErrPrefix Warning { get { return new ErrPrefix(@"\033[101m[ERR] \033[37m "); } }
        public static ErrPrefix Error   { get { return new ErrPrefix(@"\033[104m[INFO] \033[37m "); } }
    }
    public partial class Logging {
        public static void Log(ErrPrefix prefix, string content){
                Console.Write(prefix.Value + @content + "\n");
        }
    }
}