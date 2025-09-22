using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 moveDelta;
    private float fixTimeMovement = 0.25f;
    [SerializeField] private float jumpHight = 25;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {     
        float x = Input.GetAxisRaw("Horizontal");
        moveDelta = new Vector2(x, 0);
        transform.Translate(moveDelta * fixTimeMovement);

        if (Input.GetKeyDown(KeyCode.C))
        {
            rb.linearVelocity = new Vector2(0, jumpHight);
        }
    }
}
