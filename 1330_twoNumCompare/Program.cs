namespace twoNumCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            if (System.Int16.Parse(s[0]) > System.Int16.Parse(s[1]))
                Console.WriteLine(">");
            else if (System.Int16.Parse(s[0]) < System.Int16.Parse(s[1]))
                Console.WriteLine("<");
            else
                Console.WriteLine("==");
        }
    }
}