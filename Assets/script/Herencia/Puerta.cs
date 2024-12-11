using UnityEngine;
using UnityEngine.SceneManagement;
abstract public class Puerta : Interactive
{
    public string scene;
    protected void AbrirPuerta()
    {
        SceneManager.LoadScene(scene);
    }
    protected void AbrirPuerta(bool a)
    {
        if(a==true)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
