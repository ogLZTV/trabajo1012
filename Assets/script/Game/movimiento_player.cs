using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimiento_player : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;
    private Animator animator;
    public float speed;
    private float horizontal;
    private float vertical;

    public float xmin;
    public float xmax;
    private float currentX;

    public float ymin;
    public float ymax;
    private float currentY;



    void Awake()
    {
     _componentRigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        currentX = Math.Clamp(transform.position.x, xmin, xmax);
        currentY = Math.Clamp(transform.position.y, ymin, ymax);
        transform.position = new Vector2(currentX, currentY);
        if (horizontal > 0)
        {
            animator.SetTrigger("Right");
        }
        else if(horizontal < 0)
        {
            animator.SetTrigger("Left");
        }
        else
        {
            animator.SetTrigger("Down");
        }

    }

    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("enemy"))
        {
            SceneManager.LoadScene("pantalladerrota");
        }

        
    }




}
