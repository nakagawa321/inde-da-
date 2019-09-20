using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public AudioClip shot;
    public AudioClip bomb;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSound_shot()
    {
        audioSource.PlayOneShot(shot);
    }

    public void playSound_bomb()
    {
        audioSource.PlayOneShot(bomb);
    }
}
