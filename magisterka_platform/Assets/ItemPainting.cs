using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemPainting : TriggerEvent
{
    public GameObject collectedFX;
    public AudioClip sound;
    bool isUsed = false;

    public override void OnContactPlayer()
    {
        if (isUsed)
            return;

        isUsed = true;

        SoundManager.PlaySfx(sound);
        Destroy(gameObject);
    }
}