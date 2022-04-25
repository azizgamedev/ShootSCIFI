using System;
using Player;
using UnityEngine;

namespace Enemy
{
    public class EnemyFollow : MonoBehaviour
    {
        private Transform _target;

        private float _moveSpeed = 2;

        private Animator _animator;

        private float _distance;

        private void Awake()
        {
            _target = GameObject.FindWithTag("Player").transform;
            _animator = GetComponent<Animator>();
        }

        private void Move()
        {
             _distance = Vector3.Distance(_target.position, transform.position);

            if (_distance > 3)
            {
                transform.LookAt(_target);
            
                transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
            }

            else
            {
                _animator.SetTrigger("IsAttacking");
            }
            
        }

        public void DamagePlayer()
        {
            if (_distance < 3)
            {
                _target.GetComponent<PlayerHP>().ReduceHp(20);
            }
        }
        
        private void Update()
        {
            Move();
        }
    }
}
