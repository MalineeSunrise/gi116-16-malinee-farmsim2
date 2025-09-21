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

        
        cow.Init("Sakura" , 35, 20);
        farmanimal.Add(cow);

        
        chicken.Init("Suo", 20, 15);
        farmanimal.Add(chicken);

        
        sheep.Init("Noya", 25, 10);
        farmanimal.Add(sheep);

        

        foreach (var animals in farmanimal)
        {
            animals.Status();
        }

        foreach (var feedAnimal in farmanimal)
        {
            feedAnimal.Makesound();
            feedAnimal.Feed(8);
        }

        chicken.Feeds("Grain" , 7);
        chicken.Sleep();
        chicken.Status();

        cow.Feeds("Hay", 10);
        cow.Moo();
        cow.Status();

        sheep.Feeds("Pasture" , 9);
        sheep.Status();
    }
}
