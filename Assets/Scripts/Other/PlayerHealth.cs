using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 100;
    private int frameCounter;

    // Start is called before the first frame update
    void Start()
    {
        frameCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Health < 100)
        {
            frameCounter++;
        }
        
        if(frameCounter >= 60*1)
        {
            Health++;
            frameCounter = 0;
        }



        if(Health <= 0)
        {
            //Game over______________________________________________________________________________________________________

            //______________________________________________________________________________________________________
        }


        //Health UI update______________________________________________________________________________________________________

        //______________________________________________________________________________________________________

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            EnemyType enemyType = other.GetComponent<EnemyType>();
            if(enemyType.currentEnemyType == EnemyType.Enemy_Type.Nat)
            {
                Health -= 1;
            }
            if (enemyType.currentEnemyType == EnemyType.Enemy_Type.Roach)
            {
                Health -= 5;
            }
            if (enemyType.currentEnemyType == EnemyType.Enemy_Type.Prawn)
            {
                Health -= 10;
            }
            if (enemyType.currentEnemyType == EnemyType.Enemy_Type.Rat)
            {
                Health -= 15;
            }
            if (enemyType.currentEnemyType == EnemyType.Enemy_Type.Croc)
            {
                Health -= 20;
            }

        }
    }
}
