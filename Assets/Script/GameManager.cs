using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;


public class GameManager : MonoBehaviour
{

    private static List<string> animalName = new List<string> { "Chicken" , "Cow" , "Sheep"};
    public Cow cow;
    public Chicken chicken;
    public Sheep sheep;
    public List<Animals> farmanimal;
    

    void Start()
    {

        Debug.Log(" ******** Welcome to the Farm Sim *******");
        Debug.Log($" ******** Now this Fram have Animal {animalName.Count} *******");

        
        cow.Init("Sakura");
        farmanimal.Add(cow);

        
        chicken.Init("Suo");
        farmanimal.Add(chicken);

        
        sheep.Init("Noya");
        farmanimal.Add(sheep);

        

        foreach (var animals in farmanimal)
        {
            animals.Status();
        }

        chicken.Sleep();
        chicken.Status();

        cow.Moo();
        cow.Status();

        foreach (var feedAnimal in farmanimal)
        {
            feedAnimal.Makesound();
            feedAnimal.Feed(8);
        }

        sheep.Product();

        cow.Feed1(10);
        cow.Feeds(FoodType.Hay, 10);
        cow.Product();
        cow.Feeds(FoodType.Hay, 10);
        cow.Product();

        sheep.Feeds(FoodType.RottenFood, 10);

        chicken.Feeds(FoodType.AnimalFood, 20);

        chicken.Product();
    }
}
