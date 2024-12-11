using UnityEngine;

public class llave : Interactive
{
    Inventario inventario;
    public static Inventario operator +(Inventario inventario, llave llave)
    {
        inventario.agregar(llave.gameObject.name);
        return inventario;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inventario != null)
        {
            inventario += this;
            Destroy(gameObject);
        }
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.gameObject.tag == "Player")
        {
            inventario = collision.gameObject.GetComponent<Inventario>();
        }
    }
    protected override void OnTriggerExit2D(Collider2D collision)
    {
        base.OnTriggerExit2D(collision);
        if (collision.gameObject.tag == "Player")
        {
            inventario = null;
        }
    }
}
