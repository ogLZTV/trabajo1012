using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyController : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;
    private Vector2 positionInitial;
    private Transform positionPlayer;

    public float speed;
    public float aceleration;
    float acelerationInicial;
    private void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        positionInitial = transform.position;
        acelerationInicial = 1;
    }

    private void Update()
    {
        acelerationInicial = Mathf.Clamp(acelerationInicial, 1, aceleration);
        if (positionPlayer != null)
        {
            acelerationInicial += Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, positionPlayer.position, speed*acelerationInicial * Time.deltaTime);
        }
        else
        {
            acelerationInicial -= Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, positionInitial, speed*acelerationInicial * Time.deltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            positionPlayer = null;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            positionPlayer = collision.transform; 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("pantallafinal");
        }
    }
}
