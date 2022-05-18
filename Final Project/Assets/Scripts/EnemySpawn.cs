using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    float timer = 5;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            GameObject p = Instantiate(enemy,
                                       transform.position,
                                       transform.rotation);
            timer = 5;
        }
    }
}
