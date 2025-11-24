using UnityEngine;

public class MovingInLoopPlatform : MonoBehaviour
{
    [SerializeField] private Transform target1;
    [SerializeField] private Transform target2;
    [SerializeField] private float speed;
    private BoxCollider2D boxCollider;
    private BoxCollider2D target1Coll;
    private BoxCollider2D target2Coll;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        target1Coll = target1.GetComponent<BoxCollider2D>();
        target2Coll = target2.GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector2(speed * Time.deltaTime, 0));

        Debug.Log(boxCollider.IsTouching(target2Coll));
        if (boxCollider.IsTouchingLayers(LayerMask.GetMask("Target2")))
        {
            speed = -speed;
        }
    }
}
