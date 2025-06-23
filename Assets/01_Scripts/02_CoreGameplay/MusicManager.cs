using System;
using ArthemyDev.ScriptsTools;
using UnityEngine;

public class MusicManager : SingletonManager<MusicManager>
{
    [SerializeField] private AudioSource Music;
    [SerializeField] private AudioClip DefaultMusic;
    [SerializeField] private AudioClip HalfThresholdMusic;
    [SerializeField] private AudioClip AlmostOverMusic;


    private void OnEnable()
    {
        currMusic = musicThreshold.DEFAULT;
        Music.clip = DefaultMusic;
        Music.Play();
    }

    private musicThreshold currMusic= musicThreshold.DEFAULT; 
    
    public void SetMusicHalfThreshold()
    {
        if (currMusic == musicThreshold.DEFAULT)
        {
            Music.Stop();
            currMusic = musicThreshold.HALF;
            Music.clip = HalfThresholdMusic;
            Music.Play();
        }
    }

    public void SetMusicAlmostOver()
    {
        if (currMusic == musicThreshold.HALF)
        {
            Music.Stop();
            currMusic = musicThreshold.ALMOSTOVER;
            Music.clip = AlmostOverMusic;
            Music.Play();
        }
    }
    
}

enum musicThreshold
{
    DEFAULT,
    HALF,
    ALMOSTOVER,
}