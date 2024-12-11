using UnityEngine;

public class PuertaConllave : Puerta
{
    public string llave;
    public bool puedeEntrar;

    public static bool operator ==(PuertaConllave puertaConllave, Inventario inventario)
    {
        return puertaConllave.llave == inventario.llave;
    }

    public static bool operator !=(PuertaConllave puertaConllave, Inventario inventario)
    {
        return puertaConllave.llave != inventario.llave;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&interactive==true)
        {
            Debug.Log("Entro");
            AbrirPuerta(puedeEntrar);
        }
    }

    protected override void OnTriggerExit2D(Collider2D collision)
    {
        base.OnTriggerExit2D(collision);
        if (collision.gameObject.tag == "Player")
        {
            puedeEntrar = false;
        }
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.gameObject.tag == "Player")
        {
            Inventario inventario = collision.gameObject.GetComponent<Inventario>();
            if (inventario != null)
            {
                puedeEntrar = this == inventario;
            }
        }
    }
}
