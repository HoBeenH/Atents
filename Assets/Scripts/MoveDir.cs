using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDir : MonoBehaviour
{
    public float height = 1f; // ����
    public float step = 1f;   // �̵���
    private float dir = 1f;   // ����

    void Update()
    {
        // ���� Y������ 0
        if(transform.position.y >= height)
        {
            // �ִ� ���̰��� �ɸ��� -1
            dir = -1;
        }
        else if (transform.position.y <= 0)
        {
            // ���鿡 ������ 1
            dir = 1;
        }

        Vector3 _newPosition = transform.position;
        _newPosition.y = _newPosition.y + dir * Time.deltaTime * step;
        transform.position = _newPosition;
    }
}
