using UnityEngine;
using UnityEngine.SceneManagement;

public class Danger : MonoBehaviour
{
    //[SerializeField] private string sceneToLoadAnew;
    [SerializeField] private float x;
    [SerializeField] private float y;
    private BoxCollider2D boxCollider;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();    
    }

    void FixedUpdate()
    {
        if (boxCollider.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            //SceneManager.LoadScene(sceneToLoadAnew);
            GameObject.FindWithTag("Player").transform.SetPositionAndRotation(new Vector3(x, y, 0), transform.rotation);
        }
    }
}
