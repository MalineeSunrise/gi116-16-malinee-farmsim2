using UnityEngine;

public class Sheep : Animals
{
    public int Wool { get; private set; }

    public override void Init(string name)
    {
        base.Init(name);
        foodType = FoodType.Herbivore;
        Wool = 0;
    }

    public override void Makesound()
    {
        //base.Makesound();
        Debug.Log($" {Name} say baaa baaa ");
    }

    public override string Product()
    {
        if (Happiness <= 50 && Happiness >= 79)
        {
            int totalWool = 1;
            Wool += totalWool;
            Debug.Log($"{Name} poduct {totalWool} units, Total Wool : {Wool}");
        }
        else if (Happiness >= 80)
        {
            int totalWool = 2;
            Wool += totalWool;
            Debug.Log($"{Name} poduct {totalWool} units, Total Wool : {Wool}");
        }
        else
        {
            Debug.Log($"{Name} not enough happy to make product");
        }


        return $"total Wool : {Wool}";
    }

    
}