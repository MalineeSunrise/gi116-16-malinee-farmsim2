using UnityEngine;

public abstract class Animals : MonoBehaviour
{
    public string Name;

    private int hunger;
    public int Hunger
    {
        get { return hunger; }
        set
        {
            if (value < 0) hunger = 0;
            else if (value > 50) hunger = 50;
            else hunger = value;
        }
    }

    private int happiness;
    public int Happiness
    {
        get { return happiness; }
        set
        {
            if (value < 0) happiness = 0;
            else if (value > 50) happiness = 50;
            else happiness = value;
        }
    }

    public virtual void Init(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        hunger = newHunger;
        happiness = newHappiness;
    }

    public void AdjustHunger(int hunger)
    {
        Hunger += hunger;
    }

    public void AdjustHappiness(int happy)
    {
        Happiness += happy;
    }

    public virtual void Status()
    {
        Debug.Log($"{Name} happy : {Happiness} | hunger : {Hunger}");
    }

    public virtual void Makesound()
    {
        Debug.Log(" Animal Make sound ");
    }

    public void Feed(int feed)
    {
        happiness += feed;
        hunger -= feed;
        Debug.Log($"{Name} Received food in portions of {feed}");
    }

    public  void Feeds(string nameFeed, int feedAnimal) 
    {
        happiness += feedAnimal;
        hunger -= feedAnimal;
        Debug.Log($"{Name} was fed of {nameFeed} {feedAnimal} unit" );
    }
}
