namespace CO1204_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Campus: ");
            string campus = Console.ReadLine();

            Console.WriteLine("Enter a year: ");
            string year_str = Console.ReadLine();
            int year = int.Parse(year_str);

            Console.WriteLine("Hi {0} students", campus);
            Console.Write("Happy ");
            Console.Write("New Year {0}!", year);

            Console.Read();
        }
    }
}
