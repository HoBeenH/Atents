using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFSM : MonoBehaviour
{
    public float speed = 1f;
    public eState dir = eState.Stop;
    // �������� ���� ���� ����
    public enum eState
    {
        Stop = 0,
        Up,
        Down = -1
    }

    void Input()
    {
        //Ű���� �Է°��� ���� ���Ⱚ�� ����
        if (UnityEngine.Input.GetKey(KeyCode.UpArrow))
        {
            dir = eState.Up;
        }
        else if (UnityEngine.Input.GetKey(KeyCode.DownArrow))
        {
            dir = eState.Down;
        }
    }

    void DoMove()
    {
        //�⺻ ���Ⱚ�� Stop = 0
        if(dir != eState.Stop)
        {
            Vector3 _newposition = transform.position;
            _newposition.y = _newposition.y + (int)dir * Time.deltaTime * speed;
            transform.position = _newposition;
        }
    }
    //���ǵ� �Լ��� �� ������ ����
    private void Update()
    {
        Input();
        DoMove();
    }
}
