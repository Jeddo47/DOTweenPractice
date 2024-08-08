using DG.Tweening;
using UnityEngine;

public class ObjectMover : ObjectTransformChanger
{
    [SerializeField] private Vector3 _position;

    private void Start() 
    {
        transform.DOMove(_position, _duration).SetLoops(_repeats, _loopType);    
    }
}
