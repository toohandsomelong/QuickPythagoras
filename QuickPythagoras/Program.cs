using System.Data;

namespace QuickPythagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            DataTable table = new DataTable();
            while (true)
            {
                while (true)
                    try
                    {
                        Console.Write("a = ");
                        a = Convert.ToSingle(table.Compute(Console.ReadLine(), ""));
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine(e.Message);
                        continue;
                    }
                while (true)
                    try
                    {
                        Console.Write("b = ");
                        b = Convert.ToSingle(table.Compute(Console.ReadLine(), ""));
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine(e.Message);
                        continue;
                    }

                Console.WriteLine("Result: " + Math.Sqrt(a * a + b * b));
                Console.WriteLine("Press Ctrl + C to END");
            }
        }
    }
}
