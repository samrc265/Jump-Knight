using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5f; // Speed at which the object moves

    public enum Direction { Left, Right } 
    public Direction initialDirection = Direction.Right;
    public float delay = 5f;

    private bool movingRight; 

    void Start()
    {
        //Destroy(gameObject, delay);
        gameObject.SetActive(false);
        movingRight = initialDirection == Direction.Right;
    }

    void Update()
    {
        float direction = movingRight ? 1 : -1;

        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);
    }

    public void ChangeDirection()
    {
        movingRight = !movingRight;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            ChangeDirection();
        }
    }
}
