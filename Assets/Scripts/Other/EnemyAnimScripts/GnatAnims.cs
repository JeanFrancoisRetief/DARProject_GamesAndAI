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
        }
        else
        {
            gnatAnimator.SetBool("AttackRange", true);
            StartCoroutine(gnatSound());
        }
    }

    public IEnumerator gnatSound()
    {
        enemyScript.gnatSound.Play();

        yield return new WaitForSeconds(1.5f);
    }
}