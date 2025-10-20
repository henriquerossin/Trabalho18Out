using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho18Out.Entities
{
    public class Menu
    {
        public static List<string> Options { get; set; } = new List<string>();
        public static string? Title { get; set; }

        public Menu(string title, List<string> options)
        {
            Title = title;
            Options = options;
        }

        public static int Display()
        {
            Console.WriteLine(Title);
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
            Console.Write("Escolha uma opção válida: ");
            return int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
