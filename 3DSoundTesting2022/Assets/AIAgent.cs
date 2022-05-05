using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIAgent : MonoBehaviour
{
    public Transform destination;
    private NavMeshAgent agent;
    private AudioSource AS;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        AS = GetComponent<AudioSource>();
        //agent.offmesh..
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(destination.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ASDXF");
        AS.Play();
    }
}
