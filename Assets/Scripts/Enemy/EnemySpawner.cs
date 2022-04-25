using System.Collections;
using UnityEngine;

namespace Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _enemy;

        [SerializeField] private int _enemySpawnNumber;

        [SerializeField] private int _coolDown;
        
        void Start()
        {
            RestartCoroutine();
        }

        private IEnumerator EnemySpawn()
        {
            for (int i = 0; i < _enemySpawnNumber; i++)
            {
                int rndX = Random.Range(-10, 11);
                int rndZ = Random.Range(-16, 36);

                Instantiate(_enemy, new Vector3(rndX, 0, rndZ), Quaternion.identity);
            }

            yield return new WaitForSeconds(_coolDown);
            
            RestartCoroutine();
        }

        private void RestartCoroutine()
        {
            StartCoroutine(EnemySpawn());
        }
    }
}
