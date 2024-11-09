using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Death : MonoBehaviour
{
    private DeathManager DeathManager;
    
    private void Awake()
    {
        
    }
    void Start()
    {
        DeathManager = GameObject.FindGameObjectWithTag("DeathManager").GetComponent<DeathManager>();
       
    }

    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("death"))
        {
            Time.timeScale = 0;
            DeathManager.OnCanvas.SetActive(false);
            DeathManager.gameOverCanvas.SetActive(true);
            vibrateOnCondition();
            FindObjectOfType<AudioManager>().playSound("PlayerDeath");
        }
    }
    
    //vibrate device
    public void vibrateOnCondition()
    {
        Handheld.Vibrate();
        
    }
}
