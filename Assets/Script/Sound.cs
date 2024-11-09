using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public AudioClip _audioClip;
    [Range(0f, 5f)]
    public float volume;
    [Range(1f, 5f)]
    public float pitch;
    public string audioName;
    [HideInInspector]
    public AudioSource source;
    public bool loop;
    public bool pause;
}
