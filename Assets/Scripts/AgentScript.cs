﻿using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour
{

    public Transform target;
    public Transform[] targets;
    public NavMeshAgent[] agent;
    private int i = 0;

    // Use this for initialization
    void Start()
    {
        agent[i].SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        var dist = Vector3.Distance(targets[i].position, transform.position);
        target = targets[i];
        if (dist < 2)
        {
            i++;
            if (i < targets.Length)
                agent[i].destination = targets[i].position;
        }
    }
}
