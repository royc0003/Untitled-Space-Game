using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public SoundS[] sounds;
    
    // Start is called before the first frame update
    void Awake()
    {
        foreach (SoundS s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }
    }

    // Update is called once per frame
    public void Play(string name)
    {
        SoundS s = Array.Find(sounds, sound => sound.name == name);

        if (s == null)
            return;
        s.source.Play();
    }

    public void StopPlaying(string sound)
    {
        SoundS s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        //s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));

        s.source.Stop();
    }

}
