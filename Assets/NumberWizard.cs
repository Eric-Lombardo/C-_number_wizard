using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int high = 2000;
    int low = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number but don't tell me what it is");
        Debug.Log("Highest number you can pick is " + high);
        Debug.Log("Lowest number you can pick is " + low);
        Debug.Log("Tell me if you're number is higher or lower than 500");
        Debug.Log("Push up = higher, push down = lower, push enter = correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            Debug.Log("Up Arrow key was pressed.");
            low = guess;
            Debug.Log("the minimum is now: " + low );
            Debug.Log("is your number " + guess + "?");
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow was pressed");
            high = guess;
            Debug.Log("the maximum is now: " + high);
            Debug.Log("is your number " + guess + "?");
        } else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("Return was pressed");
            Debug.Log("The computer guessed your number!!");
        }
    }
}
