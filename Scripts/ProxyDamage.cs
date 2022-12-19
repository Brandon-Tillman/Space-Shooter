using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{
    // The damage per second
    public float DamageRate = 10f;

    void OnTriggerStay(Collider Col)  // This will be called every frame for as long as an intersection state persist. The health points is reduced by the damage rate which is multipled by time to get damage per ssecond(DPS)
    {
        Health H = Col.gameObject.GetComponent<Health>();

        if (H == null)
        {
            return;
        }

        H.HealthPoints -= DamageRate * Time.deltaTime;
    }
}


// This script will deal damage to any colliding object with a Health component