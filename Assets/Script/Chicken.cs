using UnityEngine;

public class Chicken : Animals
{
    public int Egg { get; private set; }

    public override void Init(string name)
    {
        base.Init(name);
        foodType = FoodType.Grain;
        Egg = 0;
    }

    public override void Makesound()
    {
        //base.Makesound();
        Debug.Log($"{Name} says Culck-a-doodle-do!");
    }

    public void Sleep()
    {
        AdjustHappiness(10);
        AdjustHunger(10);
        Debug.Log($"{Name} slept and now {Name} fells a little hungy, but {Name} very happy | Current happy : {Happiness}");
    }

    public override string Product()
    {
        if (Happiness <= 51 && Happiness >= 79)
        {
            int totalEgg = 2;
            Egg += totalEgg;
            Debug.Log($"{Name} poduct {totalEgg} units, Total Egg : {Egg}");
        }
        else if (Happiness >= 80)
        {
            int totalEgg = 3;
            Egg += totalEgg;
            Debug.Log($"{Name} poduct {totalEgg} units, Total Egg : {Egg}");
        }
        else
        {
            Debug.Log($"{Name} not enough happy to make product");
        }

        return $"total Egg : {Egg}";

    }
}
