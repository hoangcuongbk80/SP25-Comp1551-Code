namespace CO1204_Console
{
    internal class Lecture5_Generics
    {
        static void swap(ref int a, ref int b)
        {
            int tempt = a;
            a = b;
            b = tempt;
        }
        static void swap(ref double a, ref double b)
        {
            double tempt = a;
            a = b;
            b = tempt;
        }
        static void swap<FPT>(ref FPT left, ref FPT right)
        {
            FPT Tempt;
            Tempt = left;
            left = right;
            right = Tempt;
        }
        public static void Main1(string[] args)
        {
            int a = 6;
            int b = 9;
            double c = 6.9;
            double d = 9.6;

            Console.WriteLine($"Before: \nA: {a} \nB: {b}");
            //swap(ref a, ref b);
            swap<int> (ref a,ref b);
            Console.WriteLine($"A: {a} \nB: {b}");

            Console.WriteLine($"Before: \nC: {c} \nD: {d}");
            //swap(ref c, ref d);
            swap<double>(ref c, ref d);
            Console.WriteLine($"After: \nC: {c} \nD: {d}");

            
        }
    }
}
