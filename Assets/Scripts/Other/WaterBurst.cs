using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBurst : MonoBehaviour
{
    public GameObject hole;
    public GameObject webCover;

    //goes on Water Burst
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Web")
        {
            hole.SetActive(false);
            webCover.SetActive(true);

            //++ pipe bursts covered - add later
        }
    }
}
