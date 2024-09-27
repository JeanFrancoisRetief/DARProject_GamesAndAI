using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrawnAnims : MonoBehaviour
{
    public EnemyMovement enemyScript;
    public Animator prawnAnimator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript.distance > 20)
        {
            prawnAnimator.SetBool("InRange", false);
            prawnAnimator.SetBool("AttackRange", false);
        }
        else
        {
            prawnAnimator.SetBool("InRange", true);
        }

        if (enemyScript.distance < 20 && enemyScript.distance > 10)
        {
            prawnAnimator.SetBool("AttackRange", false);
        }
        else
        {
            prawnAnimator.SetBool("AttackRange", true);
            prawnAnimator.SetBool("InRange", true);
        }

        if (enemyScript.distance < 10)
        {
            enemyScript.prawnSound.mute = false;
        }
        else
        {
            enemyScript.prawnSound.mute = true;
        }
    }
}
