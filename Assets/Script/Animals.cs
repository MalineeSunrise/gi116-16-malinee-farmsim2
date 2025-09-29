using UnityEngine;
using UnityEngine.TextCore.Text;

public enum FoodType
    {
        Hay,
        Grain,
        Herbivore,
        RottenFood,
        AnimalFood
    }

public abstract class Animals : MonoBehaviour
{
    //public int maxH = 100;

    public string Name { get; private set ;}

    public int Hunger { get; private set; }
   
    public int Happiness { get; private set; }

    public FoodType foodType { get; protected set; } 

    public virtual void Init(string newName)
    {
        Name = newName;
        Happiness = 50;
        Hunger = 50;
        
    }

    public void AdjustHunger(int hunger)
    {
        Hunger = Mathf.Clamp(Hunger + hunger, 0, 100);
    }

    public void AdjustHappiness(int happy)
    {
        Happiness = Mathf.Clamp(Happiness + happy, 0, 100);
    }

    public virtual void Status()
    {
        Debug.Log($"{Name} happy : {Happiness} | hunger : {Hunger} | Prefered Food {foodType}");
    }

    public abstract void Makesound();

    public void Feed(int feed)
    {
        Hunger -= feed;
        Happiness += feed;
        Debug.Log($"{Name} was eats food {feed} unit | Current Happy : {Happiness}");
    }

    public void Feed1(int feed)
    {
        //Happiness += feed;
        Hunger -= feed;

        int Happpy = feed / 2;
        Happiness += Happpy;

        Debug.Log($"{Name} Received general food in portions of {feed} unit | Current Happy : {Happiness}");
    }

    public  void Feeds(FoodType foodTypes, int food) 
    {
        switch (foodTypes)
        {


            case FoodType.Hay:
                Hunger -= food;
                if (foodTypes == foodType)
                {
                    AdjustHappiness(15);
                }
                Debug.Log($"{Name} was very happy to eat {food} unit of Hay, Current Happy : {Happiness} and Current Hungy : {Hunger}");
                break;

            case FoodType.Grain:
                Hunger -= food;
                if (foodTypes == foodType)
                {
                    AdjustHappiness(15);
                }
                Debug.Log($"{Name} was very happy to eat {food} unit of Grain, Current Happy : {Happiness} and Current Hungy : {Hunger}");
                break;

            case FoodType.Herbivore:
                Hunger -= food;
                if (foodTypes == foodType)
                {
                    AdjustHappiness(15);
                }
                Debug.Log($"{Name} was very happy to eat {food} unit of Herbivore, Current Happy : {Happiness} and Current Hungy : {Hunger}");
                break;

            case FoodType.RottenFood:
                AdjustHappiness(-60);
                Debug.Log($"{Name} eat rotten food and now {Name} Unhappy, Current happy {Happiness} and hungy : {Hunger}");
                break;

            case FoodType.AnimalFood:
                Feed(food);
                break;
        }
    }

    public abstract string Product();
}
