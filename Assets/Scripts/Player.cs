using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 moveDelta;
    private float fixTimeMovement = 0.25f;
    private Vector2 falling;
    private GameObject[] groundLayer;
    private BoxCollider2D collider;

    void Start()
    {
        groundLayer = GameObject.FindGameObjectsWithTag("Ground");
    }

    private void FixedUpdate()
    {     
        moveDelta = Vector2.zero;
        falling = new Vector2(0, -1);

        for (int i = 0; i < groundLayer.Length; i++)
        {
            Debug.Log(transform.position + " " + groundLayer[i].transform.position);
            if (transform.position.Equals(groundLayer[i].transform.position))
            {
                Debug.Log("Dzia³a!");
                falling = Vector2.zero;
                break;
            }
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
