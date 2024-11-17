using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    void Awake()
    {
        foreach  (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s._audioClip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            //s.source.pause = s.pause;
        }
    }
    void Start()
    {
        UnityEngine.SceneManagement.Scene currentScene = SceneManager.GetActiveScene();

        
        string sceneName = currentScene.name;
        if (sceneName == "GamePlay")
        {
            playSound("GameplayTheme");
        }
        else
        {
            playSound("MainMenuTheme");
        }
       
    }

    public void playSound(string name)
    {
        Sound s = Array.Find(sounds,sound=>sound.audioName == name);
        
        if(s==null)
        {
            Debug.LogError("Sound " +  name + "not  found");
            return;
        }
        s.source.Play();
    }
}
