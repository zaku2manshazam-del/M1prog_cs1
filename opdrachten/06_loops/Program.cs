namespace _06_loops;

class Program
{
    static void Main()
    {
        int[] nummers = { 42, 60, 89 };

        for (int i = 0; i < nummers.Length; i++)
        {
            int nummer = nummers[i];
            Console.WriteLine(nummer);
        }
    }
}
