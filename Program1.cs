using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalOperatorsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userMessage;
            int repetitions;

            Console.Write("Введите сообщение: ");
            userMessage = Console.ReadLine();
            Console.Write("Введите количество повторений:");
            repetitions = Convert.ToInt32(Console.ReadLine());

            while (repetitions-- > 0)
            {
                Console.WriteLine(userMessage);
            }
        }
    }
}
