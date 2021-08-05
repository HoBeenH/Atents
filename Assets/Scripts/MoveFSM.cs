using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFSM : MonoBehaviour
{
    public float speed = 1f;
    public eState dir = eState.Stop;
    // 열거형을 통해 보기 쉽게
    public enum eState
    {
        Stop = 0,
        Up,
        Down = -1
    }

    void Input()
    {
        //키보드 입력값에 따라 방향값을 변경
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
        //기본 방향값은 Stop = 0
        if(dir != eState.Stop)
        {
            Vector3 _newposition = transform.position;
            _newposition.y = _newposition.y + (int)dir * Time.deltaTime * speed;
            transform.position = _newposition;
        }
    }
    //정의된 함수만 매 프레임 실행
    private void Update()
    {
        Input();
        DoMove();
    }
}
