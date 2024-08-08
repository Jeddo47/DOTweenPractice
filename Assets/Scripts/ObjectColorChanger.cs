using DG.Tweening;
using UnityEngine;

public class ObjectColorChanger : ObjectTransformChanger
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _color;

    private void Start()
    {
        _meshRenderer.material.DOColor(_color, _duration).SetLoops(_repeats, _loopType);
    }
}
