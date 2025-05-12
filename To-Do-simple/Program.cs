using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Use this To-Do for easy");
                Program prg = new Program();
                ConsoleKeyInfo key = prg.GetInput();
                List<Task> tasks = new List<Task>();
                int index = 0;

                while (key.Key != ConsoleKey.D6)
                {
                    switch (key.Key)
                    {
                        case ConsoleKey.D1: // add new todos
                            Console.WriteLine("Enter task detail: ");
                            string item = Console.ReadLine(); // get the task description
                            Task newTask = new Task();
                            newTask.NewTask(item);
                            tasks.Add(newTask);
                            Console.WriteLine("New task added!!");
                            key = prg.GetInput();
                            break;

                        case ConsoleKey.D2: // view all todos
                            Console.WriteLine("Showing all the tasks:");
                            if (tasks.Count == 0)
                            {
                                Console.WriteLine("No tasks to view");
                            }
                            else
                            {
                                foreach (Task task in tasks)
                                {
                                    Console.WriteLine($"Task: {task.Description} ------ Compeleted: {task.IsTaskDone}");
                                }
                            }

                            Console.WriteLine("----------finished----------");
                            key = prg.GetInput();
                            break;

                        case ConsoleKey.D3: // delete a todo
                            Console.WriteLine("Remove a task: ");
                            bool isDeleted = false;
                            foreach (Task item1 in tasks)
                            {
                                Console.WriteLine($"want to delete this item? (Y/N): {item1}");
                                ConsoleKeyInfo ynkey = Console.ReadKey();
                                if (ynkey.Key == ConsoleKey.Y)
                                {
                                    tasks.Remove(item1);
                                    isDeleted = true;
                                    Console.WriteLine("----------deleted----------");
                                    key = prg.GetInput();
                                    break;
                                }
                            }
                            if (isDeleted)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("----------finished loading all tasks----------");
                                key = prg.GetInput();
                                break;
                            }

                        case ConsoleKey.D4:
                            Console.WriteLine("Complete a task:");
                            bool isFinished4 = false;
                            foreach (Task task in tasks)
                            {
                                Console.WriteLine($"want to complete this task? (Y/N): {task.Description}");
                                ConsoleKeyInfo ynkey = Console.ReadKey();
                                if (ynkey.Key == ConsoleKey.Y)
                                {
                                    task.TaskFinish();
                                    isFinished4 = true;
                                    Console.WriteLine("----------done----------");
                                    key = prg.GetInput();
                                    break;
                                }
                            }
                            if (isFinished4)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("----------finished loading all tasks----------");
                                key = prg.GetInput();
                                break;
                            }

                        case ConsoleKey.D5:
                            Console.WriteLine("Uncomplete a task:");
                            bool isFinished5 = false;
                            foreach (Task task in tasks)
                            {
                                Console.WriteLine($"want to ucomplete this task? (Y/N): {task.Description}");
                                ConsoleKeyInfo ynkey = Console.ReadKey();
                                if (ynkey.Key == ConsoleKey.Y)
                                {
                                    task.TaskUnFinish();
                                    isFinished5 = true;
                                    Console.WriteLine("----------done----------");
                                    key = prg.GetInput();
                                    break;
                                }
                            }
                            if (isFinished5)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("----------finished loading all tasks----------");
                                key = prg.GetInput();
                                break;
                            }

                        default:
                            Console.WriteLine("Invalid key!!!");
                            key = prg.GetInput();
                            break;
                    }
                }

                Console.WriteLine("Ok Bye!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        private ConsoleKeyInfo GetInput()
        {
            Console.WriteLine("Enter the number to do the operation of your choice");
            Console.WriteLine("1. Add a new task");
            Console.WriteLine("2. View all tasks");
            Console.WriteLine("3. Delete a task");
            Console.WriteLine("4. Complete task");
            Console.WriteLine("5. Uncomplete task");
            Console.WriteLine("6. Exit");

            //get input
            return Console.ReadKey();
        }
    }

    internal class Task
    {
        private string _Description;
        private bool _IsTaskDone;


        public string Description { 
            get
            {
                return _Description;
            } 
            set
            {
                if (value.Length < 10)
                {
                _Description = value;

                }
                else
                {
                    throw new Exception("length should be less than 10 characters");
                    
                }
            }
        }

        public bool IsTaskDone
        {
            get {
                return _IsTaskDone;
            }
            set { _IsTaskDone = value; }
        }
        
        public void NewTask(string description)
        {
            Description = description;
        }

        public bool TaskFinish()
        {
            IsTaskDone = true;
            return true;
        }

        public bool TaskUnFinish()
        {
            IsTaskDone = false;
            return true;
        }

    }
}
