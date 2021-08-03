using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDir : MonoBehaviour
{
    public float height = 1f; // 높이
    public float step = 1f;   // 이동폭
    private float dir = 1f;   // 방향

    void Update()
    {
        // 현재 Y포지션 0
        if(transform.position.y >= height)
        {
            // 최대 높이값에 걸리면 -1
            dir = -1;
        }
        else if (transform.position.y <= 0)
        {
            // 지면에 닿으면 1
            dir = 1;
        }

        Vector3 _newPosition = transform.position;
        _newPosition.y = _newPosition.y + dir * Time.deltaTime * step;
        transform.position = _newPosition;
    }
}
