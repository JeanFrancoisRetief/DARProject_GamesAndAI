using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyType : MonoBehaviour
{
    public GameObject NatObj;
    public GameObject RoachObj;
    public GameObject PrawnObj;
    public GameObject RatObj;
    //public GameObject CrocObj;

    private NavMeshAgent enemyNavMeshAgent;
    private BoxCollider enemyBoxCollider;

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
            //CrocObj.SetActive(true);

            enemyBoxCollider.center = new Vector3(0, 5, 0); 
            enemyBoxCollider.size = new Vector3(20, 20, 20);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
