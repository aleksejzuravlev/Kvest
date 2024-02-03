using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6;
    public float jump = 10;
    private float moveInputX; 

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveInputX = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(moveInputX, rb.velocity.y);
    }
}
