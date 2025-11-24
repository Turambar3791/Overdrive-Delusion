using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    [SerializeField] private Transform platformToMove;
    [SerializeField] private Transform destination;
    [SerializeField] private float speed = 8;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (boxCollider.IsTouchingLayers(LayerMask.GetMask("Player"))) 
        {
            platformToMove.transform.position = Vector2.MoveTowards(platformToMove.position, destination.position, speed * Time.deltaTime);
        }
    }
}
