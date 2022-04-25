using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerMove))]
    public class PlayerRotate : MonoBehaviour
    {
        public void Rotate(Vector3 direction)
        {
            if (direction != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(direction);
            }
        }
    }
}
