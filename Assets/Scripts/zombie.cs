using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.AI;

public class zombie : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anim;   

    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
        Player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
        
    }
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, Player.transform.position);
        anim.SetFloat("distance", dist);
        if(dist < 1.5f) agent.speed = 0;
        
       else agent.SetDestination(Player.transform.position);
    }
}
