namespace plus;

class Program
{
    static void Main(string[] args)
    {

        int leeftijdstudent = 17;
        int nummerVariable = 0; //we starten op 0

        // we rekenen tellen 0 + 1 uit, EN DAN zetten we het resultaat (1) in nummervariable met de = 
        nummerVariable = leeftijdstudent + 1;
        Console.WriteLine("Year 1 happy birthday!");
        Console.WriteLine($"je bent nu {nummerVariable}");
    }
}
