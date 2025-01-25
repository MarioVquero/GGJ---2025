using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showText : MonoBehaviour
{
    public bool inRange = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // instantiate or activate a gameobject with the script for the specific NPC
        if(inRange)
        {
            Debug.Log("IN RANGE");
        }   
    }




    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            inRange = true;
        }
        else
        {
            inRange = false;
            Debug.Log("out range");
        }
    }


}
