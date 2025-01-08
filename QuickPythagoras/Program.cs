namespace QuickPythagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            
            while (true)
            {
                Console.Write("a = ");
                while (!(float.TryParse(Console.ReadLine(), out a)))
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("a = ");
                }
                Console.Write("b = ");
                while (!(float.TryParse(Console.ReadLine(), out b)))
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("b = ");
                }

                Console.WriteLine(Math.Sqrt(a * a + b * b));
                Console.WriteLine("Press Ctrl + C to end");
            }
        }
    }
}
