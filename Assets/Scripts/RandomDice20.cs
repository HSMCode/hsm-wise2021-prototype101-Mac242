using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDice20 : MonoBehaviour
{
    public int currentDiceNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            currentDiceNumber = Random.Range(1, 21);
            Debug.Log(currentDiceNumber);
        }
    }
}
