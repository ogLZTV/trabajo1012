using UnityEngine;

public class puertaTurbia : Puerta
{
    public AudioSource sfx;
    public GameObject panel;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && interactive == true)
        {
            AbrirPuerta();
        }
        if(interactive == true)
        {
            panel.SetActive(true);
            Debug.Log(interactive);
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
