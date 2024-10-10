using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241010
{
    internal class _20241010_Prac01_根本悠希
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1番目の数字を入力してください。");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2番目の数字を入力してください。");
                int num2 = int.Parse(Console.ReadLine());
                int addNum = Add(num1, num2);
                Console.WriteLine($"{num1}+{num2}={addNum}");
                int subNum = Sub(num1, num2);
                Console.WriteLine($"{num1}-{num2}={subNum}");
                int mulNum = Mul(num1, num2);
                Console.WriteLine($"{num1}*{num2}={mulNum}");
                int DivNum = Div(num1, num2);
                Console.WriteLine($"{num1}/{num2}={DivNum}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("エラー:０で割ることはできません");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("エラー：入力が無効です。整数を入力してください");
            }
            finally
            {

                Console.WriteLine("計算を終了");
            }
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Div(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("０で割ろうとしてます。");
            }
            return num1 / num2;
        }
    }
}
