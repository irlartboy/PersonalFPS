using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class Agent : MonoBehaviour
{
    private NavMeshAgent agent;

   
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

   public void GoHere(Vector3 position)
    {
        agent.SetDestination(position);
    }
}
