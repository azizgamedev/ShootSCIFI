using Enemy;
using UnityEngine;


namespace Player
{
    public class PlayerShoot : MonoBehaviour
    {
        [SerializeField] private float _range;

        [SerializeField] private float _damage;

        [SerializeField] private Camera _playerCamera;

        [SerializeField] private float _repeatRate;

        [SerializeField] private Transform _shootPoint;

        private void Shoot()
        {
            RaycastHit hit;
           
            if (Physics.Raycast(_shootPoint.position, _playerCamera.transform.forward, out hit, _range))
            {
                if (hit.collider.gameObject.TryGetComponent(out EnemyHP hp))
                {
                    var hitObject = hit.collider.gameObject;
                    
                    hitObject.GetComponent<EnemyHP>().ReduceHP(_damage);
                }
            }
        }

        public void InvokeShoot()
        {
            InvokeRepeating(nameof(Shoot), .001f, _repeatRate);
        }
    }
}
