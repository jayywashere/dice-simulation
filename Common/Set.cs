namespace DiceSim.Common;

public class DiceSet
{
    private List<Dice> _dice = [];
    public int Count => _dice.Count;

    public DiceSet(params Dice[] dices)
    {
        _dice = [.. dices];
    }

    public int RollAllDice()
        => _dice.Sum(d => d.Roll());

    public int RollRandomDie()
        => _dice[Random.Shared.Next(_dice.Count)].Roll();

    public bool IsEmpty() => _dice.Count == 0;
    public void Clear() => _dice.Clear();
    public void Add(Dice dice) => _dice.Add(dice);
}