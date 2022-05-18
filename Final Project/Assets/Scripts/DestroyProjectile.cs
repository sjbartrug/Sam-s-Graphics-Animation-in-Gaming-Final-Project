using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    public GameObject explosion;
    public string targetTag = "Target";

    private void OnCollisionEnter(Collision c)
    {
        GameObject g = c.gameObject;
        if(g.CompareTag(targetTag))
        {
            Destroy(g);
        }

        GameObject e = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(e, 1);

        Destroy(this.gameObject);
    }
}
