using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int high;
    int low;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            low = guess;
            CalculateNewGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            high = guess;
            CalculateNewGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("The computer guessed your number!!");
            StartGame();
        }
    }

    void CalculateNewGuess() 
    {
        guess = (low + high) / 2;
        Debug.Log("is your number " + guess + "?");
    }

    void StartGame() 
    {
        high = 2000;
        low = 1;
        guess = 1000;
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number but don't tell me what it is");
        Debug.Log("Highest number you can pick is " + high);
        Debug.Log("Lowest number you can pick is " + low);
        Debug.Log("Tell me if you're number is higher or lower than " + guess);
        Debug.Log("Push up = higher, push down = lower, push enter = correct");
        high++;
    }
}
