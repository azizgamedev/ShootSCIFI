using System;
using UnityEngine;
using UnityEngine.Events;

namespace Enemy
{
    public class EnemyHP : MonoBehaviour
    {
        [SerializeField] private float _hp = 100;

        [SerializeField] private UnityEvent _onEnemyDead;

        private ScoreCounter _score;

        private void Awake()
        {
            _score = GameObject.FindObjectOfType<ScoreCounter>();
        }

        public void ReduceHP(float damage)
        {
            if (_hp > 1)
            {
                _hp -= damage;
            }
            else
            {
                _onEnemyDead.Invoke();
                _score.AddScore(1);
            }
        }
    }
}
