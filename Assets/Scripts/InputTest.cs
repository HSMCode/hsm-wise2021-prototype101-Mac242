using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public bool myFirstBool;

    public int numberOne = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space Key was pressed");
            numberOne++;
            print(numberOne);
        }
                
    }
}
