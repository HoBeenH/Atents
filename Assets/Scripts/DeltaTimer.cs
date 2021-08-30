using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTimer : MonoBehaviour
{
    float a = 0f;
    float b = 0f;
    public int temp = 20;
    public float ftest = 100;

    float Countera()
    {        
        return a += 1.0f;
    }

    float Counterb()
    {        
        return b += 1.0f * Time.deltaTime;
    }

    private void Update()
    {
        Debug.LogFormat($"{(int)Countera()} . {(int)Counterb()}");
    }
}
