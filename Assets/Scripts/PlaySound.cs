using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.Play();
    }

}
