using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Barracuda;

public class StTrigger : MonoBehaviour
{
    public GameObject camera;
    public NNModel modelAsset;


    private void OnTriggerEnter(Collider other)
    {
        
        camera.GetComponent<StyleTransfer>().modelAsset = modelAsset;
        camera.GetComponent<StyleTransfer>().enabled = true;
        /*
        if (camera.GetComponent<StyleTransfer>().enabled == true)
        {
            camera.GetComponent<StyleTransfer>().enabled = false;
            camera.GetComponent<StyleTransfer>().modelAsset = modelAsset;
            
        }
        else
        {
            camera.GetComponent<StyleTransfer>().modelAsset = modelAsset;
        }
        camera.GetComponent<StyleTransfer>().enabled = true;
        */
    }


}
