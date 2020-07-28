using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip dash, gunshot;
    static AudioSource audioSource;
    void Start()
    {
        dash = Resources.Load<AudioClip>("Dash");
        gunshot = Resources.Load<AudioClip>("Gunshot");
        audioSource = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clip)
    {
        AudioClip ac = null;
        switch(clip)
        {
            case "dash": ac = dash; break;
            case "gunshot": ac = gunshot; break;
        }
        if (ac != null)
        {
            audioSource.PlayOneShot(ac);
        } else
        {
            Debug.LogError("Sound " + clip + " not found.");
        }
    }
}
