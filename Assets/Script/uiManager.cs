using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _musicOffButton;
    [SerializeField]
    private GameObject _musicOnButton;
    
    public void turnOffMusic()
    {
        _musicOffButton.SetActive(false);
        _musicOnButton.SetActive(true);
        AudioListener.pause = false;
    }

    public void turnOnMusic()
    {
        _musicOnButton.SetActive(false);
        _musicOffButton.SetActive(true);
        AudioListener.pause = true; ;
    }
}
