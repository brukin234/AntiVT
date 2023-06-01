using System;
using System.IO;

namespace AntiVT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (BaseBoardSerial() == true)
            {
                Console.WriteLine("This is not VT machine");
            }
        }
        public static bool BaseBoardSerial()
        {
            foreach (string file in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)))
            {
                if (!file.Contains("Acrobat Reader") & !file.Contains(".pdf"))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
