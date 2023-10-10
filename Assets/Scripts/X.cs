using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("awake");
    }
    Rotate rotateRef;
    void Start()
    {
        rotateRef = GetComponent<Rotate>();
        if (rotateRef != null)
        {
            rotateRef.PrintHello();
        }
    }

}
