using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
   [SerializeField]  private GameObject Coin;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(0, 5);
        Debug.Log(rand);
        if(rand==1)
        {
            //GameObject c=Instantiate(Coin, gameObject.transform);
            GameObject c = ObjectPool.instance.GetPooledObjects();
            if(c!=null )
            {
                c.transform.position = gameObject.transform.position;
                c.SetActive(true);
                c.transform.SetParent(null);
            }
            
        }
        
    }

}
