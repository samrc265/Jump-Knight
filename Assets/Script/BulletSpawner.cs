using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnInterval = 2f; 
    public Transform spawnLocation; 

    void Start()
    {
        
        InvokeRepeating("SpawnBullet", 0f, spawnInterval);
    }

    void SpawnBullet()
    {
        
        //Instantiate(bulletPrefab, spawnLocation.position, spawnLocation.rotation);
        GameObject bullet = ObjectPool.instance.GetPooledObjects();

        if(bullet != null )
        {
            
            bullet.transform.position = spawnLocation.position;
            bullet.SetActive(true);
        }
    }
}
