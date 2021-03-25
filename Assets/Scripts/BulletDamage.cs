using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<HealthManager>() == null)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
