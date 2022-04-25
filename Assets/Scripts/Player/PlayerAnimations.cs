using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Animator))]
    public class PlayerAnimations : MonoBehaviour
    {
        private Animator _playerAnimator;
        
        private void SetAnimationStateBool(string animationName, bool state)
        {
            _playerAnimator.SetBool(animationName, state);
        }

        private void SetAnimationStateTrigger(string animationName)
        {
            _playerAnimator.SetTrigger(animationName);
        }
        
        private void Awake()
        {
            _playerAnimator = GetComponent<Animator>();
        }

        public void RunOrIdle(Vector3 direction)
        { 
            if (direction != Vector3.zero)
            {
                SetAnimationStateBool("IsRunning", true);
            }
            else
            {
                SetAnimationStateBool("IsRunning", false);
            }
        }

      
        public void Jump()
        {
            SetAnimationStateTrigger("IsJumping");
        }

        public void Dance()
        {
            SetAnimationStateTrigger("IsDancing");
        }

        public void Shoot()
        {
            SetAnimationStateBool("IsShooting", true);
        }

        public void StopShoot()
        {
            SetAnimationStateBool("IsShooting", false);
        }
    }
}
