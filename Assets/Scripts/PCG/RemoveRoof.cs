using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRoof : MonoBehaviour
{
    public GameObject roof;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.tag == "Player")
        {
            roof.SetActive(false);
        }
    }
}
