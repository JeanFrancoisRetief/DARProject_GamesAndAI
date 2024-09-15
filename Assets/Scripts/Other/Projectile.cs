using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    //[Header("Main EnemyMovmentScript (On enemy)")]
    //public EnemyMovement EnemyMovmentScript;
    [Header("Bullets")]
    public float timer = 5;
    private float bulletTime;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float Speed;

    [Space(5)]
    public int ammoCount;
    public int ammoReloadTimeInSec = 1;
    private int framecounter;
    public Text ammoText;

    // Start is called before the first frame update
    void Start()
    {
        ammoCount = 8;
        framecounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (EnemyMovmentScript.distance < 20)
        {
            ShootAtPlayer();
        }*/

        Ammo();

        if(Input.GetKeyDown(KeyCode.Mouse0) && ammoCount > 0)
        {
            Shoot();
            
        }
        else
        {
            ///sound effect to show you're out of ammo
            ///

        }

    }

    void Shoot()
    {
        //bulletTime -= Time.deltaTime;

        //if (bulletTime > 0) return;

        //bulletTime = timer;

        GameObject bullet = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation) as GameObject;
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.AddForce(bulletRB.transform.forward * Speed);
        Destroy(bullet, 5f);

        ammoCount--;

        //Invoke(nameof(Reload), 2);
    }


    void Ammo()
    {
        framecounter++;

        if(framecounter >= 60*ammoReloadTimeInSec && ammoCount < 8)
        {
            ammoCount++;
            framecounter = 0;
        }

        ammoText.text = ammoCount.ToString();
    }

    void Reload()
    {
        ammoCount++;
    }
}
