using UnityEngine;
using DG.Tweening;

public class Rotater : MonoBehaviour
{
    [SerializeField] private Vector3 _angle;
    [SerializeField] private float _duration;
    [SerializeField] private RotateMode _rotateMode = RotateMode.Fast;

    [SerializeField] private int _loopCount = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    [SerializeField] private Ease _ease = Ease.Linear;

    private void Start() => 
        transform.
            DOLocalRotate(_angle, _duration, _rotateMode).        
            SetLoops(_loopCount, _loopType).
            SetEase(_ease);
}