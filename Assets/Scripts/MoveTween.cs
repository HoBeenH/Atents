using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTween : MonoBehaviour
{
    private Ease old_easyType; //이전 애니메이션 종류
    public Ease easyType;      //현재 애니메이션 종류
    public float time = 1f;    //애니메이션 시간
    private Vector3 oldPosition;

    public float right = 280f;

    private void Awake()
    {
        oldPosition = this.transform.localPosition;
        old_easyType = Ease.Unset;
        easyType = Ease.Unset;
        
    }

    void Update()
    {
        if (old_easyType != easyType)
        {
            old_easyType = easyType;
            transform.localPosition = oldPosition;

            transform.DOKill();
            if (easyType != Ease.Unset)
            {
                
                transform.DOLocalMoveX(right, time).SetLoops(-1, LoopType.Incremental).SetEase(easyType);
            }
        }
    }
}