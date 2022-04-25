using UnityEngine;

namespace Effects
{
    public class ShootSound : MonoBehaviour
    {
        [SerializeField] private AudioSource _shootSound;
        [SerializeField] private float _repeatRate;
        private void Shoot()
        {
            _shootSound.Play();
        }

        public void PressShoot()
        {
            InvokeRepeating(nameof(Shoot), .001f, _repeatRate);
        }

      
    }
}
