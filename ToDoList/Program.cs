using System;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            //preapare a list to save data from file
            List<string> toDoFromFile = new List<string>();
            string toDoFilePath = @"";
            toDoFromFile = File.ReadAllLines(toDoFilesPath).ToList();


            foreach(string task in toDoFromList)
            {
                Console.WriteLine(task);
            }
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a task Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter a task");
                    string userTAsk = Console.Readlne();
                    toDoFromList.Add(userTask);
                    Console.WriteLine($"Task {userTask} added.");
                }
                else
                {
                    Console.WriteLine("Take care!");
                    loopActive = false;
                }
            }
            FileStyleUriParser.WriteAllLines(toDoFilePath, ToDoFromFile.ToArray());



        }
    }
}
