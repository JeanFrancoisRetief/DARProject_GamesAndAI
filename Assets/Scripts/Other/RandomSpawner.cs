using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject Enemy;
    
    public GameObject Arch;
    public int randomNum;
    // Start is called before the first frame update
    void Start()
    {
        //Nat.SetActive(false);
        //Roach.SetActive(false);
        Arch.SetActive(false);
        randomNum = Random.Range(1, 4);
        if (randomNum == 1)
        {
            //Nat.SetActive(true);
            GameObject spawnedNat = Instantiate(Enemy, transform);
            spawnedNat.GetComponent<EnemyType>().currentEnemyType = EnemyType.Enemy_Type.Nat;
        }
        else if(randomNum == 2)
        {
            GameObject spawnedRoach = Instantiate(Enemy, transform);
            spawnedRoach.GetComponent<EnemyType>().currentEnemyType = EnemyType.Enemy_Type.Roach;
            
        }
        else
        {
            Arch.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
