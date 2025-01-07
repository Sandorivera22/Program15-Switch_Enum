using System;
using System.ComponentModel;
namespace Enumeraciones_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "TasK 1", EstimatedHours = 6, Status = Status.Completed },
                new Todo { Description = "TasK 2", EstimatedHours = 2, Status = Status.InProgress },
                new Todo { Description = "TasK 3", EstimatedHours = 8, Status = Status.NotStarted },
                new Todo { Description = "TasK 4", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "TasK 5", EstimatedHours = 6, Status = Status.InProgress },
                new Todo { Description = "TasK 6", EstimatedHours = 2, Status = Status.NotStarted },
                new Todo { Description = "TasK 7", EstimatedHours = 14, Status = Status.NotStarted },
                new Todo { Description = "TasK 8", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "TasK 9", EstimatedHours = 8, Status = Status.InProgress },
                new Todo { Description = "TasK 10", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "TasK 11", EstimatedHours = 4, Status = Status.NotStarted },
                new Todo { Description = "TasK 12", EstimatedHours = 10, Status = Status.Completed },
                new Todo { Description = "TasK 13", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "TasK 14", EstimatedHours = 6, Status = Status.Completed }
            };

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            PrintAssessment(todos);
            Console.ReadLine();

        }
        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }
        class Todo 
        {
            public string Description { get; set; }
            public int EstimatedHours { get; set; }
            public Status Status { get; set; }
        }
        enum Status
        {
            NotStarted,
            InProgress,
            OnHold,
            Completed,
            Deleted
        }
    }
}
