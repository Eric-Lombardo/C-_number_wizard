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
        Debug.Log("Tell me if you're number is higher or lower than " + guess);
        Debug.Log("Push up = higher, push down = lower, push enter = correct");
        high++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            low = guess;
            guess = CalculateNewGuess(low, high);
            Debug.Log("is your number " + guess + "?");
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            high = guess;
            guess = CalculateNewGuess(low, high);
            Debug.Log("is your number " + guess + "?");
        } else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("The computer guessed your number!!");
        }
    }

    int CalculateNewGuess(int low, int high) 
    {
        return (low + high) / 2;
    }
}
