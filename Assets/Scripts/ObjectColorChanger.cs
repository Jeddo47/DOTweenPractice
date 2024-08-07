using DG.Tweening;
using UnityEngine;

public class ObjectColorChanger : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        _meshRenderer.material.DOColor(_color, _duration).SetLoops(_repeats, _loopType);
    }
}
