using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{

    public Transform target;
    private NavMeshAgent agent;

    public static int damage;
    public static int health;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        health = 100;
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
}
