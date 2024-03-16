using UnityEngine;
using DG.Tweening;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _size;
    [SerializeField] private float _duration;

    [SerializeField] private int _loopCount = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    [SerializeField] private Ease _ease = Ease.Linear;

    private void Start() =>
        transform.
            DOScale(_size, _duration).
            SetLoops(_loopCount, _loopType).
            SetEase(_ease);
}