using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GnatAnims : MonoBehaviour
{
    public EnemyMovement enemyScript;
    public Animator gnatAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript.distance > 6)
        {
            gnatAnimator.SetBool("AttackRange", false);

            enemyScript.gnatSound.mute = true;
        }
        else
        {
            gnatAnimator.SetBool("AttackRange", true);

            enemyScript.gnatSound.mute = false;
        }
    }
}