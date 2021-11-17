using System;
using System.IO;

namespace CreateTitpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            string directory = "Titpe21";
            string createDirectory = $@"{rootPath}\{directory}";

            bool directoryExists = Directory.Exists(createDirectory);

            if (directoryExists)
            {
                Console.WriteLine("See kaust on juba olemas");
            }
            else
            {
                Console.WriteLine($"Kaust {directory} on loodud");
                Directory.CreateDirectory(createDirectory);

            }





        }
    }
}
