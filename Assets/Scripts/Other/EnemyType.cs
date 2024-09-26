using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class EnemyType : MonoBehaviour
{
    public GameObject NatObj;
    public GameObject RoachObj;
    public GameObject PrawnObj;
    public GameObject RatObj;
    public GameObject CrocObj;

    private NavMeshAgent enemyNavMeshAgent;
    private BoxCollider enemyBoxCollider;

    public EnemyMovement enemyMovement;
    public Transform initialPos;
    public Transform pos1;
    public Transform pos2;
    public float speed = 1.0f;

    public enum Enemy_Type
    {
        Nat,
        Roach,
        Prawn,
        Rat,
        Croc
    };

    public Enemy_Type currentEnemyType;

    // Start is called before the first frame update
    void Start()
    {
        //initialPos = gameObject.transform;
        //pos1 = new Vector3(initialPos.position.x - 10, initialPos.position.y, initialPos.position.z);
        //pos1 = new Vector3(initialPos.position.x + 10, initialPos.position.y, initialPos.position.z);

        enemyNavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        enemyBoxCollider = gameObject.GetComponent<BoxCollider>();

        if (currentEnemyType == Enemy_Type.Nat)
        {
            NatObj.SetActive(true);

            enemyBoxCollider.center = new Vector3(0, 2.5f, 0.5f);
            enemyBoxCollider.size = new Vector3(2, 2, 5);
        }
        if (currentEnemyType == Enemy_Type.Roach)
        {
            RoachObj.SetActive(true);

            enemyBoxCollider.center = new Vector3(0, 0.5f, 0);
            enemyBoxCollider.size = new Vector3(2, 4, 4);
        }
        if (currentEnemyType == Enemy_Type.Prawn)
        {
            PrawnObj.SetActive(true);

            enemyBoxCollider.center = new Vector3(0, 0.5f, 0);
            enemyBoxCollider.size = new Vector3(2, 2, 4);
        }
        if (currentEnemyType == Enemy_Type.Rat)
        {
            RatObj.SetActive(true);
            enemyNavMeshAgent.speed = 14;

            enemyBoxCollider.center = new Vector3(0, 1.5f, 0);
            enemyBoxCollider.size = new Vector3(4, 5, 10);
        }
        if (currentEnemyType == Enemy_Type.Croc)
        {
            CrocObj.SetActive(true);
            enemyNavMeshAgent.speed = 0;

            enemyBoxCollider.center = new Vector3(0, 5, 0); 
            enemyBoxCollider.size = new Vector3(20, 20, 80);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentEnemyType == Enemy_Type.Croc)
        {
            if (enemyMovement.distance <= 40)
            {
                transform.position = Vector3.Lerp(pos1.position, pos2.position, Mathf.PingPong(Time.time * speed, 1.0f));
            }
        }
    }


    /*
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            initialPos = gameObject.transform;
            pos1 = new Vector3(initialPos.position.x - 10, initialPos.position.y, initialPos.position.z);
            pos1 = new Vector3(initialPos.position.x + 10, initialPos.position.y, initialPos.position.z);
        }
        
    }
    */
}
