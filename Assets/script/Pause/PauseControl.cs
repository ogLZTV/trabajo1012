using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseControl : MonoBehaviour
{
    public void Pausa()
    {
        Time.timeScale = 0;
    }
    public void Reaundar()
    {
        Time.timeScale = 1;
    }
    public void Volumen()
    {

    }
    public void Menu()
    {
        SceneManager.LoadScene("menu principal");
    }
}
