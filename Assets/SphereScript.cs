using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;
    Vector3 initLoc;
    // Use this for initialization
    void Start()
    {
        initLoc = target.position;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, target.position) > 5)
        {
            agent.SetDestination(transform.position);
        }
        else
        {
            agent.SetDestination(target.position);
        }

        if (Vector3.Distance(transform.position, target.position) < 1)
        {
            target.position = initLoc;
        }
    }
}
