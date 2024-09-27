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
    public AudioSource roachSound;
    public AudioSource ratSound;
    public AudioSource prawnSound;
    public AudioSource crocSound1;
    public AudioSource crocSound2;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");

        gnatSound.mute = true;
        roachSound.mute = true;
        ratSound.mute = true;
        prawnSound.mute = true;
        crocSound1.mute = true;
        crocSound2.mute = true;
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
