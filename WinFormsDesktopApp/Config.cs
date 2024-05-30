using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopApp
{
    internal class Config
    {
        private string currentDir = Directory.GetCurrentDirectory();
        public string FileName = "config.ini";

        public void MakeConfig()
        {
            if (!File.Exists(FileName))
            {
                using (StreamWriter sw = File.CreateText(FileName))
                {
                    Console.WriteLine("File Created @ " + currentDir);
                    sw.WriteLine("[Configuration]");
                    sw.WriteLine("Email=");
                    sw.WriteLine("RememberMe=false");
                    // Add here if more needed
                }
            } else
            {
                Console.WriteLine("File Already Exist @ " + currentDir);
            }
        }
    }
}
