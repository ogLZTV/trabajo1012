using UnityEngine;
using UnityEngine.SceneManagement;
abstract public class Puerta : Interactive
{
    public string scene;
    protected virtual void AbrirPuerta()
    {
        SceneManager.LoadScene(scene);
    }
    protected virtual void AbrirPuerta(string a)
    {
        SceneManager.LoadScene(scene);
    }
}
