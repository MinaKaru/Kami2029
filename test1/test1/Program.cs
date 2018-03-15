using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

            // 宣告變數

            Console.Write("請輸入身高:");
            string tall = Console.ReadLine();
            Console.Write("請輸入體重:");
            string weight = Console.ReadLine();
            double BMI;

            BMI = double.Parse(weight) / (double.Parse(tall) / 100 * double.Parse(tall) / 100);
            Console.WriteLine("您的BMI指數為" + BMI);
            Console.ReadLine();
        }
    }
}
