using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Transform player;
    private Transform respawnPoint;
    private Text score;
    private float maxDistance = 0f; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        GameObject respawnObject = GameObject.FindGameObjectWithTag("scorestart");

        respawnPoint = respawnObject.transform;

        score = GetComponent<Text>();
    }

    void Update()
    {

            float distance = Vector3.Distance(player.position, respawnPoint.position);

            if (distance > maxDistance)
            {
                maxDistance = distance;
            }

            score.text = Mathf.FloorToInt(maxDistance).ToString();

    }
}
