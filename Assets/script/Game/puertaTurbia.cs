using UnityEngine;
using UnityEngine.UI;

public class puertaTurbia : Puerta
{
    public AudioSource sfx;
    public GameObject panel;
    public Button button;
    private void Awake()
    {
        button.onClick.AddListener(()=>AbrirPuerta());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactive == true)
        {
            panel.SetActive(true);
            Debug.Log(interactive);
            Time.timeScale = 0;
        }
    }
}
