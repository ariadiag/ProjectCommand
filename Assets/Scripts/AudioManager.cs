using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sfx;
    public static AudioManager player;
    
    // Use this for things needing initialization
    void Awake()
    {
        if (player == null)
            player = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound curr in sfx)
        {
            curr.source = gameObject.AddComponent<AudioSource>();
            curr.source.clip = curr.clip;
            curr.source.loop = curr.loop;

            curr.source.volume = curr.volume;
            curr.source.pitch = curr.pitch;
        }
    }

    // Use this method to actually play the sound you're looking for.
    public void Play(string name)
    {
        Sound s = Array.Find(sfx, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound '" + name + "' isn't real, dude.");
            return;
        }
        s.source.Play();
    }
}
