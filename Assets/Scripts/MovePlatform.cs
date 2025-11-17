using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    [SerializeField] private Transform platformToMove;

    [Header("Destination Coords")]
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float speed = 8;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (boxCollider.IsTouchingLayers(LayerMask.GetMask("Player"))) 
        {
            Vector2 target = new Vector2(platformToMove.position.x, platformToMove.position.y - y);
            platformToMove.transform.position = Vector2.MoveTowards(platformToMove.position, target, speed * Time.deltaTime);
        }
    }
}
