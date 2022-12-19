using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float Damage = 100f;
    public float LifeTime = 2f;  // Life time of the 

    void OnEnable() // Each time an object is activated, this is called.
    {
        CancelInvoke();
        Invoke("Die", LifeTime);  // Invoke is used to disable the ammo object after the lifetime interval
    }

    void OnTriggerEnter(Collider Col)  // invoked for ammo when it enters a trigger attached to a movable entity.
    {
        // It retrieves the health component attached to the object and reduces its health by the damage amount.
        Health H = Col.gameObject.GetComponent<Health>();
        if (H == null)
        {
            return;
        }
        H.HealthPoints -= Damage;
        Die();
    }

    void Die()
    {
        gameObject.SetActive(false);
    }
}
