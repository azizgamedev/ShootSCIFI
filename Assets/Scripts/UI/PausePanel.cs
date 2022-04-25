using UnityEngine;
using DG.Tweening;

namespace UI
{
    public class PausePanel : MonoBehaviour
    {
        [SerializeField] private Ease _ease;
        [SerializeField] private float _duration;
        [SerializeField] private RectTransform _pausePanel;

        public void PausePanelOn(bool state)
        {
            if (state)
            {
                SetPauseState(Vector3.zero);
            }
            else
            {
                SetPauseState(new Vector2(0, -1081));
            }
        }

        public void SetPauseState(Vector2 position)
        {
            _pausePanel
                .DOAnchorPos(position, _duration)
                .SetEase(_ease);
        }
    }
}
