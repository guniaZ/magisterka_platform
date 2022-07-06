using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform levelPart_1;

    private void Awake()
    {
        Instantiate(levelPart_1, new Vector4(73, 15, 0), Quaternion.identity);
    }
}
