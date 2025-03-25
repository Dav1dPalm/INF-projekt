using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    public float healAmount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var h = other.GetComponentInParent<Health>();
            h.Heal(healAmount);
            Destroy(gameObject);
        }

    }
}
