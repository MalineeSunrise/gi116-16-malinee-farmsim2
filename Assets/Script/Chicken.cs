using UnityEngine;

public class Chicken : Animals
{
    private int egg;
    public int Egg { get => egg; set => egg = value; }

    public override void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
        Egg = 0;
    }

    public override void Makesound()
    {
        base.Makesound();
        Debug.Log($"{Name} says Culck-a-doodle-do!");
    }

    public void Sleep()
    {
        AdjustHappiness(10);
        AdjustHunger(10);
        Debug.Log($"{Name} slept and now {Name} fells a little hungy, but {Name} very happy | Current happy : {Happiness}");
    }

}
