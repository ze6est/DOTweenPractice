using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Текст для замены", _duration));
        sequence.Join(_text.DOColor(Color.green, _duration));
        sequence.Append(_text.DOText("Текст для добавления", _duration).SetRelative());        
        sequence.Append(_text.DOText("Текст для взлома", _duration, true, ScrambleMode.All));
        sequence.Join(_text.DOColor(Color.red, _duration));
    }
}