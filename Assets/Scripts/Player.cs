using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 moveDelta;
    private float fixTimeMovement = 0.25f;
    private float jumpHight = 25;
    private Rigidbody2D rb;
    [SerializeField] Transform groundCheck;
    private BoxCollider2D groundCheckColl;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundCheckColl = groundCheck.GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {     
        float x = Input.GetAxisRaw("Horizontal");
        moveDelta = new Vector2(x, 0);
        transform.Translate(moveDelta * fixTimeMovement);

        Debug.Log(IsGrounded());
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpHight);
        }

    }

    private bool IsGrounded()
    { 
        return groundCheckColl.IsTouchingLayers(LayerMask.GetMask("Ground"));
    }
}
