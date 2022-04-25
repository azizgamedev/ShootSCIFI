using System;
using UnityEngine;

namespace Effects
{
    public class ShootParticles : MonoBehaviour
    {
        private ParticleSystem _shoot;
        [SerializeField] private float _repeatRate;

        private void Awake()
        {
            _shoot = GetComponent<ParticleSystem>();
        }

        public void Shoot()
        {
            InvokeRepeating(nameof(InvokeShoot), .001f,_repeatRate );
        }

        private void InvokeShoot()
        {
            _shoot.Play();
        }
    }
}
