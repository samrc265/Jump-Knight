using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool instance;

    private List<GameObject> pooled = new List<GameObject>();
    private int amountToPool = 3;

    [SerializeField]
    private GameObject _coinPrefab;
    [SerializeField]
    private GameObject _bulletPrefab;
    public Transform _coinspawnLocation;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<amountToPool; i++)
        {
            
            GameObject objC = Instantiate(_coinPrefab, _coinspawnLocation);
            GameObject objB = Instantiate(_bulletPrefab);
            
                
            objC.SetActive(false);
            objB.SetActive(false);
          
            pooled.Add(objC);
            pooled.Add(objB);
          
               
                
            
            
        }
    }
    
    public GameObject GetPooledObjects()
    {
        for(int i=0;i<pooled.Count;i++)
        {
            if (!pooled[i].activeInHierarchy)
            {
                return pooled[i];
            }
           
        }
        return null;
    }
}
