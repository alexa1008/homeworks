namespace davaleba6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sheiyvanet pirveli gamocdis qulebi (0-100):");
            string input = Console.ReadLine();
            int score1 = int.Parse(input);

            Console.WriteLine("sheiyvanet meore gamocdis qulebi (0-100):");
            input = Console.ReadLine();
            int score2 = int.Parse(input);

            Console.WriteLine("sheiyvanet mesame gamocdis qulebi (0-100):");
            input = Console.ReadLine();
            int score3 = int.Parse(input);

            double average = CalculateAverage(score1, score2, score3);
            string grade = getGrade(average);
            bool passed = isPassed(average);


            if (!IsValidScore(score1))
            {
                Console.WriteLine("qula arasworia, chaweret 0-100!");
                return;
            }


            if (!IsValidScore(score2))
            {
                Console.WriteLine("qula arasworia, chaweret 0-100!");
                return;
            }

            if (!IsValidScore(score3))
            {
                Console.WriteLine("qula arasworia, chaweret 0-100!");
                return;
            }


            Console.WriteLine("sashualo: " + average);
            Console.WriteLine("shefaseba: " + grade);
            Console.WriteLine("chabarebulia: " + passed);

            double CalculateAverage(int x, int y, int c)
            {
                return (x + y + c) / 3;
            }
            string getGrade(double average)
            {
                if (average >= 90)
                {
                    return "A";
                }
                else if(average >= 80)
                {
                    return "B";
                }
                else if(average >= 70)
                {
                    return "C";
                }
                else if( average >= 60)
                {
                    return "D";
                }
                else { return "E";}
            }
            bool isPassed(double average)
            {
                return average >= 60;
            }

            bool IsValidScore(int score)
            {
                return score >= 0 && score <= 100;
            }

        }
    }
}
