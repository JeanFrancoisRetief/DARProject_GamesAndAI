using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [Header("Spider Sounds")]
    public AudioSource spiderWalkSound;
    public AudioSource webShoot;

    void Start()
    {
        spiderWalkSound.mute = true;
    }
}
