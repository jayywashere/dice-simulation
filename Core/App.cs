using DiceSim.Common;
using DiceSim.Utils;

namespace DiceSim.Core;

public class App
{
    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== DICE SIMULATOR ===");
            Console.WriteLine("1. Run Standard 2d6 Simulation");
            Console.WriteLine("2. Run Custom Dice Simulation");
            Console.WriteLine("3. Exit");
            Console.Write("\nChoose an option: ");

            int choice = Scanner.Next(new NumericRange<int>(1, 3));

            if (choice == 3) 
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            DiceSet set = new();

            if (choice == 1)
            {
                set.Add(new Dice(6));
                set.Add(new Dice(6));
            }
            else if (choice == 2)
            {
                set = CreateCustomSet();
            }

            Console.Write("Enter simulation iterations (1 to 10,000,000): ");
            int count = Scanner.Next(new NumericRange<int>(1, 10_000_000));

            Simulation sim = new(set, count);
            
            Console.WriteLine("\nRunning simulation... Please wait.");
            List<int> results = sim.Run();

            DisplayResults(results);
        }
    }

    private DiceSet CreateCustomSet()
    {
        DiceSet set = new DiceSet();
        
        Console.Write("How many dice do you want to roll? (1-100): ");
        int diceCount = Scanner.Next(new NumericRange<int>(1, 100));

        Console.Write("How many sides per die? (2-100): ");
        int sides = Scanner.Next(new NumericRange<int>(2, 100));

        for (int i = 0; i < diceCount; i++)
        {
            set.Add(new Dice(sides));
        }

        return set;
    }

    private void DisplayResults(List<int> results)
    {
        Console.WriteLine("\n--- SIMULATION RESULTS ---");
        Console.WriteLine($"Total Rounds Rolled: {results.Count:N0}");
        
        var statistics = results.GroupBy(r => r)
                                .OrderBy(g => g.Key);

        foreach (var group in statistics)
        {
            double percentage = (double)group.Count() / results.Count * 100;
            Console.WriteLine($"Total {group.Key, 3}: Rolled {group.Count(), 6:N0} times ({percentage:F2}%)");
        }

        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey(intercept: true);
    }
}