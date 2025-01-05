using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            FindObjectOfType<AudioManager>().playSound("coin");
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + 1);
            Destroy(gameObject);
            
        }
    }
}
