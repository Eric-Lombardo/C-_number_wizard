using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int high = 2000;
        int low = 1;

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
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow was pressed");
        } else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("Return was pressed");
        }
    }
}
