using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Player
{
    public class PlayerHP : MonoBehaviour
    {
        [SerializeField] private Slider _hpSlider;

        [SerializeField] private float _hpAmount = 100f;
        
        private void Awake()
        {
            SetSliderToHp();
        }

        private void SetSliderToHp()
        {
            _hpSlider.value = _hpAmount;
        }

        public void ReduceHp(float damage)
        {
            if (_hpAmount > 0)
            {
                _hpAmount -= damage;
                SetSliderToHp();
            }
            else
            {
                SceneManager.LoadScene("Menu");
            }
        }

        public void AddHp(float heal)
        {
            _hpAmount += heal;
            SetSliderToHp();
        }
    }
}
