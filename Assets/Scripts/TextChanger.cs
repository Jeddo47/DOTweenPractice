using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private string _anotherText;
    [SerializeField] private string _addedText;
    [SerializeField] private string _hackedText;
    [SerializeField] private ScrambleMode _scrambleMode;
    [SerializeField] private float _textChangeDelay;

    private void Start()
    {
        DOTween.Sequence()
            .Append(_text.DOText(_anotherText, _duration))
            .AppendInterval(_textChangeDelay)
            .Append(_text.DOText(_addedText, _duration).SetRelative())
            .AppendInterval(_textChangeDelay)
            .Append(_text.DOText(_hackedText, _duration, true, _scrambleMode));
    }
}
