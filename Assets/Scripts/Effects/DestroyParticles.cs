using UnityEngine;

namespace Effects
{
    public class DestroyParticles : MonoBehaviour
    {
        public ParticleSystem _deathParticle;

        public void SpawnDeathParticles()
        {
            _deathParticle.gameObject.transform.parent = null;
            
            _deathParticle.Play();
        }
    }
}
