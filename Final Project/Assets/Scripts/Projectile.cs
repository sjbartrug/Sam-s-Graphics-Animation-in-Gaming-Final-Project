using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectile;
    public float force = 10.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("f"))
        {
            GameObject p = Instantiate(projectile,
                                       transform.position + transform.forward * 2 + transform.right * 2.4f - transform.up,
                                       transform.rotation);
            Rigidbody prb = p.GetComponent<Rigidbody>();
            prb.AddRelativeForce(new Vector3(0, 0, force), ForceMode.Impulse);
            Destroy(p, 2);
        }

        
    }
}
