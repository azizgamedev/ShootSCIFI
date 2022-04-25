using System;
using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerJump : MonoBehaviour
    {
        private float _jumpForce = 100f;

        [SerializeField] private UnityEvent _onPlayerJump;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void ClickJump()
        {
            _onPlayerJump?.Invoke();
        }

        public void Jump()
        {
            Vector3 jumpVector = new Vector3(0, _jumpForce, 0) * Time.deltaTime;
            
            _rigidbody.AddForce(jumpVector);
        }
    }
}
