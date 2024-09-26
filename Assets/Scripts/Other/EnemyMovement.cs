using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent Enemy;
    GameObject Player;
    public float distance;

    [Header("Audio")]
    public AudioSource gnatSound;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);

        if (distance < 20)
        {
            Enemy.SetDestination(Player.transform.position);
        }

    }
}
