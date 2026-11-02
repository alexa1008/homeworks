namespace davaleba8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "gio";
            student.Surname = "kankava";
            student.Course = 3;
            student.Address = "sdasdas";
            student.Country = "georgia";
            student.Gmail = "asjdajsas"; 
            student.Age = 30;
            student.City = "tbilisi";
            student.Phone = "599123456";
            student.Specialty = "xelosani";

            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Surname: {student.Surname}");
            Console.WriteLine($"Course: {student.Course}");
            Console.WriteLine($"Address: {student.Address}");
            Console.WriteLine($"Country: {student.Country}");
            Console.WriteLine($"Gmail: {student.Gmail}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"City: {student.City}");
            Console.WriteLine($"Phone: {student.Phone}");
            Console.WriteLine($"Specialty: {student.Specialty}");
        }

    }
}
