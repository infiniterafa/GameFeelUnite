using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Norm_Ene_Move : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent Agent;
    public int EnemyLifes = 15;

    void Start()
    {
        EnemyLifes = 15;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) < 5)
        {
            Agent.SetDestination(Player.position);
        }

        if (EnemyLifes <= 0)
        {
            gameObject.SetActive(false);
        }
    }

}
