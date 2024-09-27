using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBurst : MonoBehaviour
{
    public GameObject hole;
    public GameObject webCover;

    private GameObject scriptHolderObj;
    private Score scoreScript;

    public AudioSource warterrunningSound;
    public AudioSource warterPluggingSound;

    GameObject Player;
    public float distance;

    void Start()
    {
        scriptHolderObj = GameObject.Find("ScriptHolder");
        scoreScript = scriptHolderObj.GetComponent<Score>();
        scoreScript.TotalDrains++;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if(distance < 25)
        {
            warterrunningSound.mute = false;
        }
        else
        {
            warterrunningSound.mute = true;
        }
        
    }


    //goes on Water Burst
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Web")
        {
            warterPluggingSound.Play(0);

            hole.SetActive(false);
            webCover.SetActive(true);

            //++ pipe bursts covered - add later
            scoreScript.DrainsBlocked++;
            //warterrunningSound.mute = true;
            other.gameObject.SetActive(false);
        }
    }
}
