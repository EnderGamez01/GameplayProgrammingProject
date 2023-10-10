using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartX : MonoBehaviour
{

    //[SerializeField] GameObject goRef;

    Rotate rotateRef;
    //private void Awake()
    //{
        //if (!goRef || )
    //}

    void Start()
    {
        //rotateRef = goRef.activeInHierarchy == false;
        GameObject goRef = GameObject.Find("Earth");
        rotateRef = goRef.GetComponent<Rotate>();
        if (rotateRef != null)
        {
            rotateRef.PrintHello();
        }
    }

    void Update()
    {
        
    }
}
