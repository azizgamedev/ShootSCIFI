using System;
using UnityEngine;
using DG.Tweening;

namespace Enemy
{
    public class ColorPulse : MonoBehaviour
    {
        [SerializeField] private SkinnedMeshRenderer _renderer;
        [SerializeField] private Ease _easeType;
        [SerializeField] private float _duration;

        private void Awake()
        {
            _renderer.material.DOColor(Color.white, _duration)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(_easeType);
        }
    }
}
