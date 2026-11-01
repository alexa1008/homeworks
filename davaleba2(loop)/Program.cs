namespace davaleba2_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] num1 = [20, 30, 40];
            //int[] num2 = [25, 32, 47];

            //int[] resultArray = new int[num1.Length+ num2.Length];

            //for (int i = 0; i < num1.Length; i++)
            //{
            //    resultArray[i] = num1[i];
            //}

            //for (int i = 0; i < num2.Length; i++)
            //{
            //    resultArray[num1.Length + i] = num2[i];

            //}





            int[] nums = [3, 5, -4, 8, 11, 1, -1, 6];
            int count = 0;
            Console.WriteLine("neter number");

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == number)
                    {
                        count++;
                        
                    } 
                }
            }
            int[][] result = new int[count][];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == number)
                    {
                        result[index] = [nums[i], nums[j]];
                        index++;
 

                    }
                }
            }
            foreach (var numbers in result)
            {
                foreach (var item in numbers)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
