using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6;
    public float jump = 10;
    private float moveInputX;

    public Transform startJumpCheckPoint;
    public Transform endJumpCheckPoint;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        moveInputX = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(moveInputX, rb.velocity.y);

        //анимация бега
        animator.SetFloat("Speed", Mathf.Abs(moveInputX));

        Vector3 scale = transform.localScale;

        if(moveInputX < 0)
        {
            scale.x = -Mathf.Abs(scale.x);
        }
        else if (moveInputX > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }

        transform.localScale = scale;

        isGrounded = Physics2D.Linecast(startJumpCheckPoint.position, endJumpCheckPoint.position);
        print(isGrounded);
        animator.SetBool("isGrounded", isGrounded);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(transform.up * jump, ForceMode2D.Impulse);
        }
    }

}
