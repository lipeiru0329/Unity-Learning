using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        beforeStart();
    }

    void beforeStart() {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello World!");
        Terminal.WriteLine("Hello World!");
        Terminal.WriteLine("Hello World!");
        Terminal.WriteLine("Hello World!");
    }

    void OnUserInput(string input) {
        Terminal.WriteLine("The input: " + input);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
