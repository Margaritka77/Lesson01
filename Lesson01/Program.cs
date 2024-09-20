using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Попробуйте сделать калькулятор:
            //запрашивается на вход в начале первое значение, 
            //потом второе и потом действие, результат вывести на экран. 
            Console.WriteLine("Введите первое число:");
            string sNum1 = Console.ReadLine();
            int num1 = int.Parse(sNum1);
            Console.WriteLine("Введите второе число:");
            string sNum2 = Console.ReadLine();
            int num2 = int.Parse(sNum2);
            Console.WriteLine("Введите знак:");
            string znak = Console.ReadLine();
            string strToPrint = $"{num1} {znak} {num2} = ";
            if (znak == "+")
                strToPrint += Convert.ToString(num1 + num2);
            else if (znak == "-")
                strToPrint += Convert.ToString(num1 - num2);
            else if (znak == "/")
                strToPrint += ((double)num1 / num2).ToString();
            else if (znak == "*")
                strToPrint += (num1 * num2).ToString();
            else Console.WriteLine("Такого знака не существует! Попробуйте снова!");
            Console.WriteLine(strToPrint);
        }
    }
}
