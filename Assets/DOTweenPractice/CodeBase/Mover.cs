using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private float _duration;
    [SerializeField] private bool _snapping = false;

    [SerializeField] private int _loopCount = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    [SerializeField] private Ease _ease = Ease.Linear;

    private void Start() => 
        transform.
            DOMove(_endPosition, _duration, _snapping).
            SetLoops(_loopCount, _loopType).
            SetEase(_ease);
}