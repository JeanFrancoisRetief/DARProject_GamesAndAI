using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoachAnims : MonoBehaviour
{
    public EnemyMovement enemyScript;
    public Animator roachAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript.distance > 20)
        {
            roachAnimator.SetBool("InRange", false);
        }
        else
        {
            roachAnimator.SetBool("InRange", true);
        }

        if(enemyScript.distance < 20 && enemyScript.distance > 5)
        {
            roachAnimator.SetBool("AttackRange", false);
        }
        else
        {
            roachAnimator.SetBool("AttackRange", true);
        }

        if (enemyScript.distance < 3)
        {
            enemyScript.roachSound.mute = false;
        }
        else
        {
            enemyScript.roachSound.mute = true;
        }
    }
}
