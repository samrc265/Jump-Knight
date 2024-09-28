using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Player;
    public void Awake()
    {
      GameObject a=  Instantiate(Player[PlayerPrefs.GetInt("Player")], transform);
        a.transform.SetParent(null);

    }
}
