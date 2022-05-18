using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseTarget : MonoBehaviour
{
    public float MoveSpeed;
    GameObject player;
    public float minDistance = 15;
    
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame   
    void Update()
    {
        transform.LookAt(player.transform.position);

        if (Vector3.Distance(transform.position, player.transform.position) <= minDistance)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
        
    }

}
