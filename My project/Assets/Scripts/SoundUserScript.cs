using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundUserScript : MonoBehaviour
{
    public static AudioClip winSound;
    public static AudioClip bkgMusic;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        winSound = Resources.Load<AudioClip>("fanfare");
        audioSrc = GetComponent<AudioSource>();

        bkgMusic = Resources.Load<AudioClip>("mystical");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fanfare":
                audioSrc.PlayOneShot(winSound);
                break;
    
        }
    }
}
