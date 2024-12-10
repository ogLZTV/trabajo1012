using UnityEngine;

public class MovimientoSilla : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float velocity;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rigidbody2D.velocity =new Vector2(velocity,0);
        
    }
}
