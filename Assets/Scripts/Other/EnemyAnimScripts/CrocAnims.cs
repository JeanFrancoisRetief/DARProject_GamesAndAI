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
        }
        else
        {
            crocAnimator.SetBool("inRange", true);
        }
    }
}
