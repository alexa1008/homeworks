namespace saklaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name(string name)
            {
                return name.ToUpper();
            }
            Console.WriteLine(Name("john"));

            int Sum(int x, int y)
            {
                return x + y;
            }
            int jami = Sum(7, 5);

            Console.WriteLine(jami);
            Console.WriteLine(Sum(20,10));

            bool isVallid(string name)
            {
                if(name == null || name == "")
                {
                    return false;
                }
                return true;
            }

            if (isVallid("john"))
            {
                Console.WriteLine("sjsjsjsjs");
            }

            void Print()
            {
                Console.WriteLine("hello world");
            }

            Print();




            Random random = new Random();
            random.Next();

            Program.PrintHello();
           

           
        }
        static void PrintHello()
        {
            Console.WriteLine("hello");
        }
    }
}
