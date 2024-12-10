using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntrarPasillo1 : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto que colisiona tiene el nombre "player"
        if (collision.gameObject.name == "Player")
        {
            // Carga la escena llamada "pasillo 1"
            SceneManager.LoadScene("pasillo1");
            print("waza");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // Carga la escena llamada "pasillo 1"
            SceneManager.LoadScene("pasillo1");
            print("waza2");
        }
    }
}
