using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstSound : MonoBehaviour
{
    GameObject[] Bursts;
    GameObject ClosestBurst;
    public AudioSource warterrunningSound;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        Bursts = GameObject.FindGameObjectsWithTag("Burst");
    }

    // Update is called once per frame
    void Update()
    {

        ClosestBurst = GetClosestEnemy(Bursts);
        distance = Vector3.Distance(transform.position, ClosestBurst.transform.position);
        if (distance < 30)
        {
            warterrunningSound.mute = false;
        }
        else
        {
            warterrunningSound.mute = true;
        }
    }

    GameObject GetClosestEnemy(GameObject[] enemies)
    {
        GameObject bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (GameObject potentialTarget in enemies)
        {
            Vector3 directionToTarget = potentialTarget.transform.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }

        return bestTarget;
    }
}
