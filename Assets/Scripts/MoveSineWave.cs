using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSineWave : MonoBehaviour
{
    private float theta = 0f;
    [Header("X축 이동속도")]
    public float speed_x = 5f;
    [Header("Y축 이동속도")]
    public float speed_y = 20f;
    [Header("높이")]
    public float height = 0.5f;

    bool facingRight = true;

    void Update()
    {
        Vector3 pos = transform.position;

        if (pos.x < -7f)
        {
            facingRight = true;
        }
        else if (pos.x > 7f)
        {
            facingRight = false;
        }
        if (facingRight)
        {
            pos.x += Time.deltaTime * speed_x;
        }
        else
        {
            pos.x -= Time.deltaTime * speed_x;
        }

        theta += Time.deltaTime * speed_y;
        pos.y = Mathf.Sin(theta) * height;

        transform.position = pos;
    }
}
