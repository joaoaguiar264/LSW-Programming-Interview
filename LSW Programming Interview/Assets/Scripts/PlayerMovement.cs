using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public bool facingRight = true;
    private Vector2 moveDirection;

    private Animator anim;

    public Animator animShirt;
    public Animator animPants;
    public Animator animShoes;
    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Update()
    {

        Inputs();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Inputs()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(x, y).normalized;

        float xy = x + y;
        anim.SetFloat("Speed", Mathf.Abs(xy));
        animShirt.SetFloat("Speed", Mathf.Abs(xy));
        animPants.SetFloat("Speed", Mathf.Abs(xy));
        animShoes.SetFloat("Speed", Mathf.Abs(xy));

        if (x > 0 && !facingRight)
        {
            Flip();
        }
        else if (x < 0 && facingRight)
        {
            Flip();
        }
    }

     void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
