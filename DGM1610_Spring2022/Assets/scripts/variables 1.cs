using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int Credits; //Whole number value 2, 14, -198, 57, 12
    int Arrows;
    float change = 0.84f; // Floating point number or decimal 3.18, -28.93, 129.09
    bool isDay = true; //Booleans are true or false\
    string UserName = "UserName002";

    // Start is called before the first frame update
    void Start()
    {
        Credits = 150;
        print("Credits in account = $" + Credits);
        Debug.Log("Hello World");
        Arrows = 45;
        print("Arrows in Quiver = #" + Arrows);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
