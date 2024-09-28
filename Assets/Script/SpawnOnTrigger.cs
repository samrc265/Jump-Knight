using UnityEngine;

public class SpawnOnTrigger : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    public Transform spawnLocation;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int randomIndex = Random.Range(0, spawnPrefabs.Length);
            GameObject selectedPrefab = spawnPrefabs[randomIndex];
            Instantiate(selectedPrefab, spawnLocation.position, spawnLocation.rotation);

            Destroy(gameObject);
        }
    }
}

