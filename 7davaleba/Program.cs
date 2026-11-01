namespace _7davaleba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products p = new Products(1, "burgeri", 12.5m, false, "img.jpg", false, 2, "beaf");

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.IsSafeForNutAllergy());
            Console.WriteLine(p.GetSpicinessDescription());
            Console.WriteLine(p.Category);
        }
    }
}
