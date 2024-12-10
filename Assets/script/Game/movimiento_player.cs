using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimiento_player : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;

    public float speed;
    private float horizontal;
    private float vertical;

    public float xmin;
    public float xmax;
    private float currentX;

    public float ymin;
    public float ymax;
    private float currentY;


    public string direccion;

    void Awake()
    {
     _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        currentX = Math.Clamp(transform.position.x, xmin, xmax);
        currentY = Math.Clamp(transform.position.y, ymin, ymax);
        transform.position = new Vector2(currentX, currentY);

    }

    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
   

    

}
