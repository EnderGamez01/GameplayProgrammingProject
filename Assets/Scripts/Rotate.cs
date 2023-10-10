using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float rotVelocity;

    void Update()
    {
        transform.Rotate(Vector3.up, rotVelocity * Time.deltaTime);
    }

    public void PrintHello()
    {
        Debug.Log("Hello!");
    }
}
