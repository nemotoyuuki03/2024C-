namespace _20241010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("割られる数字を入力してください。");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("割る数字を入力してください");
                int num2 = int.Parse(Console.ReadLine());

                int result = Divide(num1, num2);
                Console.WriteLine($"result=num1/num2{result}");
            }
            catch (DivideByZeroException ex) 
            { 
                Console.WriteLine("エラー：0で割ろうとしています。");
                Console.WriteLine($"詳細：{ex.Message}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("エラー：数字が正しく入力されていません。");
                Console.WriteLine($"詳細：{ex.Message}");
            }
            finally
            {
                Console.WriteLine("プログラムを終了します。");
            }
        }
       static int Divide(int num1, int num2)
       {
            if (num2 == 0)
            {
                Console.WriteLine("0で割ろうとしてます。");
            }

            return num1 /num2;
        }
    }
}
