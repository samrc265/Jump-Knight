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
        
        movingRight = initialDirection == Direction.Right;
    }

    void Update()
    {
        float direction = movingRight ? 1 : -1;

        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);


        if(transform.position.x >3.65)
        {
            gameObject.SetActive(false);
        }
    }

    public void ChangeDirection()
    {
        movingRight = !movingRight;
    }

    
}
