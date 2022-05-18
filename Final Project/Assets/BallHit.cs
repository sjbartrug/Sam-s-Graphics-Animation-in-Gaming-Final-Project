using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
