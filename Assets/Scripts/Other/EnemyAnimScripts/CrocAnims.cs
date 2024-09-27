using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrocAnims : MonoBehaviour
{
    public EnemyMovement enemyScript;
    public Animator crocAnimator;
    // Start is called before the first frame update
    void Start()
    {
        crocAnimator.SetBool("inRange", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript.distance > 40)
        {
            crocAnimator.SetBool("inRange", false);
            enemyScript.crocSound2.mute = true;
        }
        else
        {
            crocAnimator.SetBool("inRange", true);
            enemyScript.crocSound2.mute = false;
        }
    }
}
