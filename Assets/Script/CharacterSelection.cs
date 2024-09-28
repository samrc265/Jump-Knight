using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private GameObject[] Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloseALL()
    {
        for(int i=0;i<Player.Length;i++)
        {
            Player[i].SetActive(false);
        }
    }
    public void Player1()
    {
        CloseALL();
        Player[0].SetActive(true);
    }
    public void Player2()
    {
        CloseALL();
        Player[1].SetActive(true);
    }
    public void Player3()
    {
        CloseALL();
        Player[2].SetActive(true);
    }
    public void Select1()
    {
        PlayerPrefs.SetInt("Player", 0);
    }
    public void Select2()
    {
        PlayerPrefs.SetInt("Player", 1);
    }
    public void Select3()
    {
        PlayerPrefs.SetInt("Player", 2);
    }
}

