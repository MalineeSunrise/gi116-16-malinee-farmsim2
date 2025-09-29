using UnityEngine;

public class Cow : Animals
{
    public float Milk { get; private set; }

    public override void Init(string name)
    {
        base.Init(name);
        foodType = FoodType.Hay;
        Milk = 0f;
    }

    public override void Makesound() 
    {
        //base.Makesound();
        Debug.Log($"{Name} says Moo-Moo!");
    }

    public void Moo()
    {
        AdjustHappiness(6);
        Debug.Log($"{Name} says Moo!! and now {Name} happiness up ++ | Current happy : {Happiness} ");
    }

    public override string Product()
    {
        if (Happiness >= 70)
        {
            float totalMilk = Happiness / 10;
            Milk += totalMilk;
            Debug.Log($"{Name} poduct {totalMilk} units, Total Milk : {Milk}");
        }

        else
        {
            Debug.Log($"{Name} not enough happy to make product");
        }

        return $"total Milk : {Milk}"; 

    }
}