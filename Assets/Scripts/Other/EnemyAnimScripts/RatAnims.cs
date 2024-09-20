using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatAnims : MonoBehaviour
{
    public EnemyMovement enemyScript;
    public Animator ratAnimator;
    // Start is called before the first frame update
    void Start()
    {
        ratAnimator.SetBool("AttackRange", false);
        ratAnimator.SetBool("InRange", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript.distance > 20)
        {
            ratAnimator.SetBool("InRange", false);
            ratAnimator.SetBool("AttackRange", false);
        }
        else
        {
            ratAnimator.SetBool("InRange", true);
        }

        if (enemyScript.distance < 20 && enemyScript.distance > 5)
        {
            ratAnimator.SetBool("AttackRange", false);
        }
        else
        {
            ratAnimator.SetBool("AttackRange", true);
            ratAnimator.SetBool("InRange", true);
        }
    }
}
