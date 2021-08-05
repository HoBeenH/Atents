using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDir : MonoBehaviour
{
    public float height = 1f; // 높이
    public float step = 1f;   // 이동폭 (이동속도)
    private float dir = 1f;   // 방향

    void Update()
    {
        // 현재 Y포지션 0
        if(transform.position.y >= height)
        {
            // 최대 높이값에 걸리면 -1
            dir = -1f;
        }
        else if (transform.position.y <= 0)
        {
            // 지면에 닿으면 1
            dir = 1f;
        }
        // Vector3 = 3차원 자표값 ( X,Y,Z )
        // Time.deltatime = 1초를 프레임으로 나눔 = step * deltatime 은 프레임당 이동스피드
        // 방향 * 매프레임당 * 이동스피드
        Vector3 _newPosition = transform.position;
        _newPosition.y = _newPosition.y + dir * Time.deltaTime * step;
        transform.position = _newPosition;
    }
}
