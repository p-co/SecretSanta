namespace SecretSanta.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the names of the secret santas seperated by a comma.");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No names in input, ending");
                return;
            }

            List<string> names = input.Replace(" ", "").Split(",").ToList();

            if (names.Count < 2)
            {
                Console.WriteLine("Not enough participants, ending");
                return;
            }

            names = names.OrderBy(x => Guid.NewGuid()).ToList();

            for (int i = 0; i < names.Count - 1; i++)
                Console.WriteLine(names[i] + " => " + names[i + 1]);

            Console.WriteLine(names.Last() + " => " + names.First());
        }
    }
}
