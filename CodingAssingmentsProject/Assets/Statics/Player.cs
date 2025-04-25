using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Static variables are shared across all instances
    //of a calss.
    public static int playerCount =  0;

    // Start is called before the first frame update
    void Start()
    {

        //Increment the static variable to know how many
        //objects of this classs have been created.
        playerCount++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
