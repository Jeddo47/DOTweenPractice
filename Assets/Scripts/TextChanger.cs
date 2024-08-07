using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _anotherText;
    [SerializeField] private string _addedText;
    [SerializeField] private string _hackedText;
    [SerializeField] private float _duration;
    [SerializeField] private ScrambleMode _scrambleMode;
    [SerializeField] private float _textChangeDelay;

    private void Start()
    {
        StartCoroutine(StartTextChanging());
    }

    private IEnumerator StartTextChanging() 
    {
        WaitForSeconds wait = new WaitForSeconds(_textChangeDelay);

        _text.DOText(_anotherText, _duration);

        yield return wait;

        _text.DOText(_addedText, _duration).SetRelative();

        yield return wait;

        _text.DOText(_hackedText, _duration, true, _scrambleMode);

        yield return wait;

        StartCoroutine(StartTextChanging());
    }
}
