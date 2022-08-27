using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteragindoComInternet
{
    internal class Tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("Taks Object");
            Console.WriteLine($"User id: {userId}");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Complete: {completed}");
            Console.WriteLine("");
            Console.WriteLine("============================");
        }

    }
}
