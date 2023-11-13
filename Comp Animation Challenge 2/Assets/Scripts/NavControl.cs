using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavControl : MonoBehaviour
{
    public GameObject target;
    private bool isWalking = true;
    protected Animator animtor;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        animtor = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Attack"))
        {
            isWalking = false;
            animtor.SetTrigger("ATTACK");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Dragon")
        {
            isWalking = true;
            animtor.SetTrigger("WALK");
        }
    }
}
