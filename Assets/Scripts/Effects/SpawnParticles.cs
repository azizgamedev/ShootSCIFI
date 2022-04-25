using System.Collections;
using UnityEngine;

namespace Effects
{
    public class SpawnParticles : MonoBehaviour
    {

        [SerializeField] private ParticleSystem _spawnParticles;
        [SerializeField] private float _waitTime;
        private void Awake()
        {
            StartCoroutine(ParticlePlay());
        }

        private IEnumerator ParticlePlay()
        {
            _spawnParticles.Play();

            yield return new WaitForSeconds(_waitTime);
            
            _spawnParticles.Stop();
        }
    }
}
