using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTimer : MonoBehaviour
{
    float a = 0f;
    float b = 0f;

    float Countera()
    {
        // 프레임당 +=1
        return a += 1.0f;
    }

    float Counterb()
    {
        // 초당 +=1
        return b += 1.0f * Time.deltaTime;
    }

    private void Update()
    {
        Debug.LogFormat($"{(int)Countera()} . {(int)Counterb()}");
    }
}
