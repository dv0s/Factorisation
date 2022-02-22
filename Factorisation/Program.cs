class Program
{
    static void Main(string[] args)
    {
        long input, divider;
        var stopwatch = new System.Diagnostics.Stopwatch();

        Console.WriteLine("Voer je integer in: ");
        input = long.Parse(Console.ReadLine());

        if (input < Int64.MaxValue)
        {
            stopwatch.Start();

            for (divider = 2; input > 1; divider++)
            {
                if (input % divider == 0)
                {
                    long factor = 0;
                    while (input % divider == 0)
                    {
                        input /= divider;
                        factor++;
                    }

                    Console.WriteLine($"{divider} is een priemgetal factor {factor} keer!");
                }
            }
        }
        else
        {
            Console.WriteLine("That's what she said.");
        }
        stopwatch.Stop();
        Console.WriteLine($"Tijd van uitvoeren: {stopwatch.ElapsedMilliseconds} ms");
    }
}