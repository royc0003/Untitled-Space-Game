using UnityEngine.Audio;
using UnityEngine;
using System;

[System.Serializable]
public class SoundS
{
    public string name;
    public AudioClip clip;

    [Range(0f, 2f)]
    public float volume;

    [HideInInspector]
    public AudioSource source;

    public Boolean loop;

}
