using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StTriggerOff : TriggerEvent
{
    public GameObject camera;

    public override void OnContactPlayer()
    {
        camera.GetComponent<StyleTransfer>().enabled = false;
    }/*
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            camera.GetComponent<StyleTransfer>().enabled = false;
        }
        
    }
    */
}
