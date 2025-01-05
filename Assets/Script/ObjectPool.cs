using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool instance;

    private List<GameObject> pooled = new List<GameObject>();
    private int amountToPool = 4;

    [SerializeField]
    private GameObject _bulletPrefab;
    

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
            //creating object pool
            GameObject objB = Instantiate(_bulletPrefab);
            objB.SetActive(false);
            pooled.Add(objB);
        }
    }
    
    public GameObject GetPooledObjects()
    {
        //checking for number of pooled objects active in hierarchy
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
