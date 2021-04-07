using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTouched : MonoBehaviour
{
    public static SoundTouched soundTch;

    private AudioSource audioSrc;

    private AudioClip[] deathSound;

    private int randomDeathSound;


    // Start is called before the first frame update
    void Start()
    {
        soundTch = this;
        audioSrc = GetComponent<AudioSource>();
        deathSound = Resources.LoadAll<AudioClip>("DeathSound");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PlayDeathSound()
    {
        randomDeathSound = Random.Range(0, 2);
        audioSrc.PlayOneShot(deathSound[randomDeathSound]);
    }
}