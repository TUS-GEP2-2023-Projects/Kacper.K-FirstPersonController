using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    private NavMeshAgent agent;

    public List<Transform> waypoints = new List<Transform>();

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = waypoints[0].position;
    }

    public void Update()
    {
        agent.remainingDistance <= 0;
    }
}
