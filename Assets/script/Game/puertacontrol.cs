using UnityEngine;

public class puertacontrol : Puerta
{
    public AudioSource sfx;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E)&&interactive==true)
        {
            AbrirPuerta();
        }
    }
}
