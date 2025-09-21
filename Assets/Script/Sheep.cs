using UnityEngine;

public class Sheep : Animals
{
    public override void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
    }

    public override void Makesound() 
    {
        base.Makesound();
        Debug.Log($" {Name} say baaa baaa ");
    }
}
