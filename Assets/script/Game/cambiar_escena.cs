using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cambiar_escena : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    public void cambiarescena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
