using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    public AudioSource playerAudio;
    public AudioSource enemyAudio;
    public AudioSource mainAudio;


    public AudioClip death;
    public AudioClip glitch1;
    public AudioClip glitch2;
    public AudioClip escapeTheVirus;
    public AudioClip Quest;
    public AudioClip jump;
    public AudioClip pop;
    public AudioClip shot1;
    public AudioClip shot2;
    public AudioClip shot3;
    public AudioClip shot4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
