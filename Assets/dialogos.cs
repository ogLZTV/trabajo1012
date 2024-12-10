using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogos : MonoBehaviour
{
    public GameObject cuadrodetexto;
    // Start is called before the first frame update
    void Start()
    {
        cuadrodetexto.SetActive(true);
        Time.timeScale = 0;
    }

    public void cerrardialogo()
    {
        cuadrodetexto.SetActive (false);
        Time.timeScale = 1;
    }
}
