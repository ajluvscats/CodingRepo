using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class GameCreatingProperties : MonoBehaviour
{
    public CreatingPropertiesScript myPlayer;
    void Start()
    {
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
        Debug.Log("experince:" + x);
    } 
}
