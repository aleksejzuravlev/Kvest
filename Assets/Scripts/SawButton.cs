using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawButton : MonoBehaviour
{

    public GameObject Saw;
    public Sprite pushed;

    private SpriteRenderer sr;
    private bool stop = false;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && stop == false)
        {
            sr.sprite = pushed;

            Animator sawAnimator = Saw.GetComponent<Animator>();
            sawAnimator.SetTrigger("Stop");

            Collider2D col = Saw.GetComponent<Collider2D>();
            col.enabled = false;
        }

    }
}
