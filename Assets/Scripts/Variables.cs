using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public float []  values;
    private float newValue;
    public float divider;
    private float result;
    public string stringText = "Result of Division is ";
    
    // Start is called before the first frame update
    void Start()
    {
        divider = 3;
        
        values = new[] { 1f, 3f, 5f, 8f, 10f };
        newValue= values[0] + values[1] + values[2] + values[3] + values[4];
        print("Sum of Array is " + newValue);
        result = newValue / divider;
        
        print(stringText + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
