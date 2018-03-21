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
            float tall = float.Parse(Console.ReadLine()) / 100;

            Console.Write("請輸入體重:");
            float weight = float.Parse(Console.ReadLine());

            double BMI;

            BMI = weight / (tall * tall);

            if (BMI < 16.5 || BMI > 31.5)
            {
                Console.WriteLine("恭喜你不用當兵");
            }

            else if (16.5 <= BMI && BMI < 17)
            {
                Console.WriteLine("你還是得當替代役");
            }

            else if (31 <= BMI && BMI < 31.5)
            {
                Console.WriteLine("你還是得當替代役");
            }

            else
            {
                Console.WriteLine("乖乖當兵吧");
            }

            Console.WriteLine("您的BMI指數為" + BMI);
            Console.ReadLine();
        }
    }
}
