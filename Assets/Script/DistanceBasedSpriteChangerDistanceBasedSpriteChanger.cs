using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceBasedSpriteChanger : MonoBehaviour
{
    public List<Sprite> sprites; // List of sprites to cycle through
    public SpriteRenderer spriteRenderer; // The SpriteRenderer component of the GameObject

    private Transform scoreStart; // The transform of the scorestart GameObject

    private void Start()
    {
        // Find the GameObject tagged with "scorestart"
        GameObject scoreStartObject = GameObject.FindGameObjectWithTag("scorestart");
        if (scoreStartObject != null)
        {
            scoreStart = scoreStartObject.transform;
        }
        else
        {
            Debug.LogError("No GameObject tagged 'scorestart' found in the scene.");
        }

        // Ensure the SpriteRenderer is assigned
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Ensure there are sprites in the list
        if (sprites.Count == 0)
        {
            Debug.LogError("No sprites assigned to the list.");
        }
    }

    private void Update()
    {
        ChangeSpriteBasedOnDistance();
    }

    private void ChangeSpriteBasedOnDistance()
    {
        if (scoreStart != null && spriteRenderer != null && sprites.Count > 0)
        {
            // Calculate the distance between the current GameObject and the scorestart GameObject
            float distance = Vector3.Distance(transform.position, scoreStart.position);

            // Determine the index of the sprite based on the distance
            int spriteIndex = Mathf.FloorToInt(distance / 100f) % sprites.Count;

            // Change the sprite
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }
}
