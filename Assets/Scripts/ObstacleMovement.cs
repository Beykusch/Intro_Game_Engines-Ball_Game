using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Vector3 endMovePosition;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        float randomTime = time * Random.Range(0.8f, 1.5f);
        float randomDelay = Random.Range(0f, 1f);

        transform.DOLocalMove(endMovePosition, randomTime)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.Linear)
                 .SetDelay(randomDelay);
    }
}
