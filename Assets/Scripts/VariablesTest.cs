using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesTest : MonoBehaviour
{
    public GameObject myGameObject;
    
    public int myFirstinteger = 1;
    public int mySecondInteger = 2;
    public int myThirdinteger;

    public float myFirstFloat = 10.5f;
    public float mySecondFloat = 2665.5f;
    public float myThirdFloat;

    public string myFirstText = "Mein erster Text!";

    public bool myFirstBool;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myFirstinteger);
        Debug.Log(mySecondInteger);
        myThirdinteger = myFirstinteger + mySecondInteger;

        Debug.Log(myThirdinteger);

        myThirdinteger += 10;

        Debug.Log("NEU" + myThirdinteger);

        myThirdFloat = myFirstFloat + mySecondFloat;
        Debug.Log("myFirstFloat + mySecondFloat = " + myThirdFloat);

        myFirstBool = false;

    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("SPACE"); 
        */
    }
}
