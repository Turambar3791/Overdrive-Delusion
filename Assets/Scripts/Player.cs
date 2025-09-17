using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 moveDelta;
    private float fixTimeMovement = 0.25f;
    private Vector2 falling;
    private GameObject[] groundLayer;

    void Start()
    {
        groundLayer = GameObject.FindGameObjectsWithTag("Ground");
    }

    private void FixedUpdate()
    {     
        moveDelta = Vector2.zero;
        falling = new Vector2(0, -1);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down);

        if (hit)
        {
            float distance = Mathf.Abs(hit.point.y - transform.position.y);
            Debug.Log(distance);
        }

        float x = Input.GetAxisRaw("Horizontal");
        moveDelta = new Vector2(x, 0);
        transform.Translate(moveDelta * fixTimeMovement);
    }

    private void LateUpdate()
    {
        transform.Translate(falling * fixTimeMovement);
    }
}
