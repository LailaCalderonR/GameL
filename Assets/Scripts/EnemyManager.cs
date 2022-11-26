using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public GameObject player;
    public Animator enemyAnimator;

    public float damage = 20f;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

   
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position;

        if (GetComponent < NavMeshAgent>().velocity.magnitude > 1)
        {
            enemyAnimator.SetBool("isRunning", true);
        }
        else
        {
            enemyAnimator.SetBool("isRunning", false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
        {
            player.GetComponent<PlayerManager>().Hit(damage);
        }
    }
}
