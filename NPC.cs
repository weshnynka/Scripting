using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    int health = 2;
    int level = 1;
                                           
    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        string name = "health";
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
