using UnityEngine;

public class ExtendBox : MonoBehaviour
{
    public float changeInterval = 1.0f;  // Interval between size changes
    public float maxExtension = 2.0f;  // Maximum extension multiplier

    private float initialWidth;
    private BoxCollider boxCollider;  // Reference to the BoxCollider

    private void Start()
    {
        initialWidth = transform.localScale.x;
        boxCollider = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        float extensionMultiplier = 1.0f + Mathf.PingPong(Time.time / changeInterval, maxExtension - 1.0f);
        float newWidth = initialWidth * extensionMultiplier;

        // Keep the height and depth unchanged
        float currentHeight = transform.localScale.y;
        float currentDepth = transform.localScale.z;

        // Update the scale with new width and the same height and depth
        transform.localScale = new Vector3(newWidth, currentHeight, currentDepth);

        // Adjust the collider size accordingly
        if (boxCollider != null)
        {
            boxCollider.size = new Vector3(newWidth, currentHeight, currentDepth);
        }
    }
}
