using UnityEngine;
using DG.Tweening;

namespace Helping
{
    public class RotateHealing : MonoBehaviour
    {
        void Start()
        {
            transform.DOMove(new Vector3(transform.position.x, 1.3f, transform.position.z), 1)
                .SetEase(Ease.Flash)
                .SetLoops(-1, LoopType.Yoyo);
        }

       
    }
}
