using DG.Tweening;
using UnityEngine;

public class ObjectRotator : ObjectTransformChanger
{
    [SerializeField] private Vector3 _rotation;
    
    private void Start()
    {
        transform.DORotate(_rotation, _duration).SetLoops(_repeats, _loopType);
    }    
}
