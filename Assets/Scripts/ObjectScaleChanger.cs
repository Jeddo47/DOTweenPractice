using DG.Tweening;
using UnityEngine;

public class ObjectScaleChanger : ObjectTransformChanger
{
    [SerializeField] private float _scale;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(_repeats, _loopType);
    }
}
