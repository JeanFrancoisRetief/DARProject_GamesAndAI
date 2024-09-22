using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 100;
    private int frameCounter;

    public GameObject BloodSplatterImage1;
    public GameObject BloodSplatterImage2;
    public GameObject BloodSplatterImage3;
    public GameObject BloodSplatterImage4;
    public GameObject BloodSplatterImage5;
    public GameObject BloodSplatterImage6;
    public GameObject BloodSplatterImage7;
    public GameObject BloodSplatterImage8;
    public GameObject BloodSplatterImage9;
    public GameObject BloodSplatterImage10;

    public GameObject BloodDrops1;
    public GameObject BloodDrops2;


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
            SceneManager.LoadScene("Menu");
            //______________________________________________________________________________________________________
        }


        //Health UI update______________________________________________________________________________________________________
        //BloodSplatterImage.color = new Color(BloodSplatterImage.color.r, BloodSplatterImage.color.g, BloodSplatterImage.color.b, (200-(Health*2)));
        if(Health <= 10)
        {
            BloodSplatterImage1.SetActive(true);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(false);
            BloodDrops2.SetActive(true);
        }
        else if(Health <= 20)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(true);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(false);
            BloodDrops2.SetActive(true);
        }
        else if (Health <= 30)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(true);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(false);
            BloodDrops2.SetActive(true);
        }
        else if (Health <= 40)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(true);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(true);
            BloodDrops2.SetActive(false);
        }
        else if (Health <= 50)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(true);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(true);
            BloodDrops2.SetActive(false);
        }
        else if (Health <= 60)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(true);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(true);
            BloodDrops2.SetActive(false);
        }
        else if (Health <= 70)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(true);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(false);
            BloodDrops2.SetActive(false);
        }
        else if (Health <= 80)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(true);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(false);
            BloodDrops2.SetActive(false);
        }
        else if (Health <= 90)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(true);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(false);
            BloodDrops2.SetActive(false);
        }
        else if (Health < 100)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(true);

            BloodDrops1.SetActive(false);
            BloodDrops2.SetActive(false);
        }
        else if (Health == 100)
        {
            BloodSplatterImage1.SetActive(false);
            BloodSplatterImage2.SetActive(false);
            BloodSplatterImage3.SetActive(false);
            BloodSplatterImage4.SetActive(false);
            BloodSplatterImage5.SetActive(false);
            BloodSplatterImage6.SetActive(false);
            BloodSplatterImage7.SetActive(false);
            BloodSplatterImage8.SetActive(false);
            BloodSplatterImage9.SetActive(false);
            BloodSplatterImage10.SetActive(false);

            BloodDrops1.SetActive(false);
            BloodDrops2.SetActive(false);
        }




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
