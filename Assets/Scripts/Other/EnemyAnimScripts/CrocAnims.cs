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
        crocAnimator.SetBool("InRange", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript.distance > 20)
        {
            crocAnimator.SetBool("InRange", false);
        }
        else
        {
            crocAnimator.SetBool("InRange", true);
        }
    }
}
