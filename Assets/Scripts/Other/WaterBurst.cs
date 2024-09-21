using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBurst : MonoBehaviour
{
    public GameObject hole;
    public GameObject webCover;

    private GameObject scriptHolderObj;
    private Score scoreScript;

    void Start()
    {
        scriptHolderObj = GameObject.Find("ScriptHolder");
        scoreScript = scriptHolderObj.GetComponent<Score>();
        scoreScript.TotalDrains++;
    }


    //goes on Water Burst
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Web")
        {
            hole.SetActive(false);
            webCover.SetActive(true);

            //++ pipe bursts covered - add later
            scoreScript.DrainsBlocked++;

            other.gameObject.SetActive(false);
        }
    }
}
