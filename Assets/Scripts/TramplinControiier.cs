using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramplinControiier : MonoBehaviour
{
    public float strength = 5;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            animator.SetTrigger("Jump");

            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            rb.AddForce(rb.transform.up * strength, ForceMode2D.Impulse);
        }
    }
}
