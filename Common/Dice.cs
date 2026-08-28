namespace DiceSim.Common;

public class Dice
{
    public int Sides { get; }

    public Dice(int sides)
    {
        if (sides < 2)
            throw new ArgumentOutOfRangeException(
                nameof(sides),
                sides,
                "The count of sides in a general-purpose die cannot be lower than 2."
            );
        
        Sides = sides;
    }

    public int Roll() => Random.Shared.Next(1, Sides + 1);
}