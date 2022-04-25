using System;
using Player;
using UnityEngine;

namespace Helping
{
    public class Healing : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                other.GetComponent<PlayerHP>().AddHp(15);
                Destroy(gameObject);
            }
        }
    }
}
