using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    public string lightColor;

    public string weather;

    public string hairColor;

    public int age;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lightColor == "Red")
         {
             Debug.Log("The light is " + lightColor + ", halt!");
         }
         else if(lightColor == "Yellow")
         {
             Debug.Log("The light is " + lightColor + ", chill dude!");
         }
         else if (lightColor == "green")
         {
             Debug.Log("The light is " + lightColor + ", Yeet my boi!");
         }
         else
         {
             Debug.Log("COLOR ERROR");
         }

         if(weather == "Rain" || weather == "Snow")
         {
             Debug.Log("wear a beanie!");
         }
         else if(weather == "Sunny" || weather == "Partly Cloudy")
         {
             Debug.Log("wear chaos!");
         }
    
        if (hairColor == "Red" && age == 6)
        {
            Debug.Log("You can't ride this ride, Little Mister!");
        }
        else if (hairColor == "Blonde" && age == 100)
        {
            Debug.Log("Sit down and enjoy the ride, sire.");
        }


    }
}

