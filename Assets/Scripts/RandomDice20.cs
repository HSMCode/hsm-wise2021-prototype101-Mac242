using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class RandomDice20 : MonoBehaviour
{
    public int currentDiceNumber;
    public string winText = "-You WIN!";
    public string loseText = "-No Luck, try again!";
    public int[] winningNumbers = {7, 13, 1};
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //setting random range for dice
            currentDiceNumber = Random.Range(1, 21);
            //Debug.Log(currentDiceNumber);
            
            //checking for winning numbers
           // if (currentDiceNumber == 7 || currentDiceNumber ==13 || currentDiceNumber ==1)

           if (currentDiceNumber == winningNumbers[0] || currentDiceNumber == winningNumbers[1] || currentDiceNumber == winningNumbers[2])
            {
                print(currentDiceNumber + winText);
            }
            else
            {
                print(currentDiceNumber + loseText);
            }
        }        
    }
}
