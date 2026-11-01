namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] saxeli = ["Alice", "Bob", "Charlie"];
            //int[] numbers = [20, 60, 30];
            //int sum = 0;
            //foreach (var num in numbers)
            //{  sum += num;}
            //    Console.WriteLine(sum / numbers.Length);




            //int[][] jagged =
            //    [
            //    [20,30,60,15],
            //    [40,60,78],
            //    [ 12,15,65]
            //    ];
            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    int max = jagged[i][0];
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        if (jagged[i][j] > max)
            //        {
            //            max = jagged[i][j];
            //        }
            //    }
            //    Console.WriteLine(max);
            //}

            //int[][] jagged2 = [
            //    [15,20,35,45],
            //    [20,30,40],
            //    [78,95,32],
            //    [12,65,32,78]
            //    ];

            //int sum = 0;
            //int count = 0;

            //foreach (var arr in jagged2)
            //{
            //    foreach (var el in arr)
            //    {
            //        sum += el;
            //        count++;
            //    }
            //}
            //Console.WriteLine(sum / count);
            string[][] names = [
               ["n", "i","l"],
               ["g", "h", "q"],
               ["c", "n", "t"]
                ];

            foreach (var arr in names)
            {
                foreach (var el in arr)
                {
                    Console.WriteLine();
                }
            }


        }
    }
}
