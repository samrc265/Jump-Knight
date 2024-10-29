using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded = false;
    private bool isTouchingWall = false;
    private bool isMovingRight = true; // Determines the direction of the next jump

    [SerializeField] private ParticleSystem dust;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Jump();
            }
        }
    }

    void Jump()
    {
        if (isTouchingWall)
        {
            if (isMovingRight)
            {
                rb.velocity = new Vector2(jumpForce, jumpForce);
                isMovingRight = false;
                PlayDust();
            }
            else
            {
                rb.velocity = new Vector2(-jumpForce, jumpForce);
                isMovingRight = true;
                PlayDust();
            }
       
        }
        else if (isGrounded)
        {
            Debug.Log("test");
            rb.velocity = new Vector2(0, jumpForce);
        }
 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            isTouchingWall = true;
            Debug.Log("1");
            //isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            isTouchingWall = false;
        }
    }
    void PlayDust()
    {
        dust.Play();
    }
}
