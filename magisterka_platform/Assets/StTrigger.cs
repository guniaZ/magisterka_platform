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
    }
}
