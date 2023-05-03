using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrouille : MonoBehaviour
{
    [SerializeField] private Transform[] positions;
    private int positionActuelle;

    private NavMeshAgent _agentAI;

    // Start is called before the first frame update
    void Start()
    {
        _agentAI = GetComponent<NavMeshAgent>();
        positionActuelle = 0;
        _agentAI.SetDestination(positions[positionActuelle].position);
    }

    // Update is called once per frame
    void Update()
    {
        if (! _agentAI.pathPending && _agentAI.remainingDistance <= _agentAI.stoppingDistance)
        {
            positionActuelle = (positionActuelle + 1) % positions.Length;
            _agentAI.SetDestination(positions[positionActuelle].position);
        }        
    }
}
