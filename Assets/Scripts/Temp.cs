using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Temp : MonoBehaviour
{
    Sequence mySequence;

    void Start()
    {
        mySequence = DOTween.Sequence()
        .OnStart(() =>
        {
            transform.localScale = Vector3.zero;
            GetComponent<CanvasGroup>().alpha = 0;
        })
        .Append(transform.DOScale(1, 1).SetEase(Ease.OutBounce))
        .Append(transform.DOShakePosition(4,2f))
        .Join(GetComponent<CanvasGroup>().DOFade(1, 1))
        .SetDelay(0.5f);

        mySequence.SetLoops(-1, LoopType.Restart).SetDelay(1.5f);
    }
}