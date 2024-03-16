using UnityEngine;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Material _material;

    [SerializeField] private Color _startColor;
    [SerializeField] private Color _endColor;
    [SerializeField] private float _duration;

    [SerializeField] private int _loopCount = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    [SerializeField] private Ease _ease = Ease.Linear;

    private void Start() => 
        _material.DOColor(_endColor, _duration).
            SetLoops(_loopCount, _loopType).
            SetEase(_ease);

    private void OnDestroy() => 
        _material.color = _startColor;
}