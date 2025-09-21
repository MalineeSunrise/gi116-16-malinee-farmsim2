using UnityEngine;

public class Cow : Animals
{
    private float milk;
    public float Milk { get => milk; set => milk = value; }

    public override void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
        Milk = 0f;
    }

    public override void Makesound() 
    {
        base.Makesound();
        Debug.Log($"{Name} says Moo-Moo!");
    }

    public void Moo()
    {
        AdjustHappiness(6);
        Debug.Log($"{Name} says Moo!! and now {Name} happiness up ++ | Current happy : {Happiness} ");
    }
}
