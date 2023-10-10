using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myProvider : MonoBehaviour
{
    //public delegate void MyDelegate();
    private Action myDelegate;

    public Action<int> myDelegateInt;
    private Action<int, bool> myBoolDelegateInt;

    void Start()
    {
        myDelegate += foo;
        myDelegate += bar;
        myDelegate();

        myDelegateInt += fooInt;
        myDelegateInt += barInt;
        myDelegateInt(3);

        myBoolDelegateInt += boolFooInt;
        myBoolDelegateInt += boolBarInt;
        myBoolDelegateInt(5, true);

    }

    void foo()
    {
        Debug.Log("foo");
    }

    void bar()
    {
        Debug.Log("bar");
    }
    void fooInt(int x)
    {
        Debug.Log("Result:" + x);
    }
    void barInt(int x)
    {
        Debug.Log("Result: "+ x);
    }
    void boolFooInt(int x, bool b)
    {
        Debug.Log("boolFooInt x:" + x + " " + b);
        
    }

    void boolBarInt(int x, bool b)
    {
        Debug.Log("boolBarInt x: "+ x + " " + b);
        
    }
}
