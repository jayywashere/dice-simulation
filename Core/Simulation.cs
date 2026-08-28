using DiceSim.Common;

namespace DiceSim.Core;

public class Simulation
{
    private DiceSet _set { get; }
    public int SimulationCount { get; }

    public Simulation(DiceSet set, int simCount)
    {
        if (simCount < 1)
            throw new ArgumentOutOfRangeException(
                nameof(simCount),
                simCount,
                "Simulation count must be at least 1 or higher."
            );
        
        _set = set;
        SimulationCount = simCount;
    }

    public List<int> Run()
    {
        List<int> results = [];

        for (int i = 0; i < SimulationCount; i++)
            results.Add(_set.RollAllDice());

        return results;
    }
}