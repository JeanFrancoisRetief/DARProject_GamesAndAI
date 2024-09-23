using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health;
    public EnemyType enemyTypeScript;
    public GameObject deathBlood;

    private GameObject scriptHolderObj;
    private Score scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        scriptHolderObj = GameObject.Find("ScriptHolder");
        scoreScript = scriptHolderObj.GetComponent<Score>();
       
        //Player Damage = '1';
        if (enemyTypeScript.currentEnemyType == EnemyType.Enemy_Type.Nat)
        {
            Health = 1;
            scoreScript.TotalEnemies++;
        }

        if (enemyTypeScript.currentEnemyType == EnemyType.Enemy_Type.Roach)
        {
            Health = 2;
            scoreScript.TotalEnemies++;
        }

        if (enemyTypeScript.currentEnemyType == EnemyType.Enemy_Type.Prawn)
        {
            Health = 9999;
        }

        if (enemyTypeScript.currentEnemyType == EnemyType.Enemy_Type.Rat)
        {
            Health = 10;
            scoreScript.TotalEnemies++;
        }

        if (enemyTypeScript.currentEnemyType == EnemyType.Enemy_Type.Croc)
        {
            Health = 20;
            scoreScript.TotalEnemies++;
        }

        deathBlood.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            StartCoroutine(enemeyDeath());
        }
    }

    public IEnumerator enemeyDeath()
    {
        scoreScript.EnemiesDefeated++;
        deathBlood.SetActive(true);

        yield return new WaitForSeconds(2);

        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Web")
        {
            Health--;
            other.gameObject.SetActive(false);
        }
    }

}
