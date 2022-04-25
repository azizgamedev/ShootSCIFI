using System;
using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        private float _horizontalInput, _verticalInput;

        private float _moveSpeed = 5, _sprintSpeed = 8, _normalSpeed = 5;

        private Camera _mainCamera;

        public Vector3 MoveVector { get; set; }

        [SerializeField] private UnityEvent<Vector3> _onPlayerDirection;

        private FixedJoystick _joystick;

        private void Awake()
        {
           Init();
        }
        
        private void Init()
        {
            _joystick = GameObject.FindWithTag("Joystick").GetComponent<FixedJoystick>();
            _mainCamera = Camera.main;
        }
        private void Update()
        {
           Move();
           Sprint();
        }

        private void SpeedSetter(float speedValue)
        {
            _moveSpeed = speedValue;
        }

        private void Move()
        {
            _horizontalInput = _joystick.Horizontal;
            _verticalInput = _joystick.Vertical;

            var cameraTransform = _mainCamera.transform;
            
            Vector3 forward = cameraTransform.forward;
            Vector3 right = cameraTransform.right;

            forward.y = 0;
            right.y = 0;
            
            forward.Normalize();
            right.Normalize();

            MoveVector = (forward * _verticalInput + right * _horizontalInput) * _moveSpeed * Time.deltaTime;
            
            transform.position += MoveVector;
            
            _onPlayerDirection?.Invoke(MoveVector);
        }

        private void Sprint()
        {
            SpeedSetter(Input.GetKey(KeyCode.LeftShift) ? _sprintSpeed : _normalSpeed);
        }
    }
}
