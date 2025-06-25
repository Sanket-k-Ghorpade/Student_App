namespace Student_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation using default constructor
            Student s1 = new Student();

            //object creation with negative roll no
            try
            {
                Student s2 = new Student(-1, "Rakesh", 9.6);
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Object Creation failed!!");
            }

            //object creation with invalid cgpa 
            try
            {
                Student s3 = new Student(1, "Rakesh", 11.2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
                Console.WriteLine("Object Creation failed!!");
            }

            //object creation with name with length less than 5
            Student s4 = new Student(1, "jai", 7.4);
            Console.WriteLine("\nOutput from object with name.Length < 5: ");
            Console.WriteLine($"Name: {s4.Name}");

            //object creation with all valid paramters
            Student s5 = new Student(2, "Sanket", 9.7);
            Console.WriteLine("\nOutput from object with name.Length > 5: ");
            Console.WriteLine($"Percentage of {s5.Name}: {s5.CalculatePercentage()}");
        }
    }
}
