using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace ISpan.ComponentDevelopment.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool IsNumber = int.TryParse(Console.ReadLine(), out int number);
            if (!IsNumber)
            {
                Console.WriteLine("請輸入正整數");
            }
            else
            {
                Console.WriteLine(number + " : " + number.IsPrime());
            }
        }
    }
}
