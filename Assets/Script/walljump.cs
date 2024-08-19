using UnityEngine;

public class WallJump : MonoBehaviour
{
    public float jumpForce = 10f;
    public float wallSlideSpeed = 2f;
    public LayerMask wallLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isTouchingWall;
    private bool isWallSliding;
    private bool isFacingRight = true;
    private bool jumpToRightWall = true;

    public Transform groundCheck;
    public Transform wallCheck;
    public float checkRadius;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.freezeRotation = true;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, wallLayer);
        isTouchingWall = Physics2D.OverlapCircle(wallCheck.position, checkRadius, wallLayer);

        if (isTouchingWall && !isGrounded && rb.velocity.y < 0)
        {
            isWallSliding = true;
        }
        else
        {
            isWallSliding = false;
        }

        if (isWallSliding)
        {
            rb.velocity = new Vector2(rb.velocity.x, -wallSlideSpeed);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (isGrounded)
            {
                Vector2 groundJumpDirection = isFacingRight ? Vector2.right : Vector2.left;
                rb.velocity = new Vector2(groundJumpDirection.x * jumpForce, jumpForce);
            }
            else if (isWallSliding)
            {
                Vector2 wallJumpDirection = jumpToRightWall ? Vector2.right : Vector2.left;
                rb.velocity = new Vector2(wallJumpDirection.x * jumpForce, jumpForce);
                Flip(wallJumpDirection.x);
                jumpToRightWall = !jumpToRightWall;
            }
        }
    }

    private void Flip(float direction)
    {
        if ((direction > 0 && !isFacingRight) || (direction < 0 && isFacingRight))
        {
            isFacingRight = !isFacingRight;
            Vector3 scaler = transform.localScale;
            scaler.x *= -1;
            transform.localScale = scaler;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(wallCheck.position, checkRadius);
    }
}
