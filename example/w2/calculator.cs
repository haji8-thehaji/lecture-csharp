using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            String tmpnum1, tmpnum2;
            int num1, num2;
            ConsoleKeyInfo Conkey;
            do
            {
                do
                {
                    Console.WriteLine("연산을 수행할것을 선택하시오 ( + - * /)");
                    Conkey = Console.ReadKey(true);
                } while (Conkey.KeyChar != '+' && Conkey.KeyChar != '-' && Conkey.KeyChar != '*' && Conkey.KeyChar != '/');


                do
                {
                    Console.WriteLine("연산할 첫번째 수를 입력하세요");
                    tmpnum1 = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(tmpnum1));

                do
                {
                    Console.WriteLine("연산할 두번째 수를 입력하세요");
                    tmpnum2 = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(tmpnum2));


                num1 = Convert.ToInt32(tmpnum1);
                num2 = Convert.ToInt32(tmpnum2);




                if (Conkey.KeyChar == '+')
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (Conkey.KeyChar == '-')
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (Conkey.KeyChar == '*')
                {
                    Console.WriteLine(num1 * num2);
                }
                else if (Conkey.KeyChar == '/')
                {
                    Console.WriteLine(num1 / num2);
                }

            } while (Conkey.Key != ConsoleKey.Escape);

        }
    }
}
