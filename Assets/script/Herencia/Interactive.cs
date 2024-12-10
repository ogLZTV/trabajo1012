using UnityEngine;

abstract public class Interactive : MonoBehaviour
{
    protected bool interactive;
    //protected void OnTriggerEnter2D(Collision2D collision)  
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        interactive = true;
    //    }
    //}
    //protected void OnTriggerExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        interactive = false;
    //    }
    //}
protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           interactive = true;
        }

    }
    protected void OnTriggerExit2D(Collider2D collision)
    {
    if (collision.gameObject.tag == "Player")
    {
        interactive = false;
    }
}


}
