using System.Collections.Generic;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            while (true)
            {
                string option = "";
                string description;
                bool isCompleted;
                Console.Write("Input your option: ");
                option = Console.ReadLine().ToLower();
                if (option == "q" || option == "quit")
                {
                    Console.WriteLine("Quiting Application...");
                    System.Threading.Thread.Sleep(2000);
                    break;
                }
                else if (option == "insert" || option == "i")
                {
                    Console.WriteLine("Inserting new task...");
                    tasks.Add(new Task(5, "description5", false));
                    continue;
                }
                else if (option == "delete" || option == "d")
                {

                    continue;
                }
                else if (option == "show" || option == "s")
                {
                    foreach(Task task in tasks)
                    {
                        Console.WriteLine(task.ToString());
                    }

                    //continue;s
                    Console.WriteLine(tasks.Count);

                }
                else if (option == "complete" || option == "c")
                {

                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter correct option or keyword!");
                    continue;
                }
            }
        }
    }
}