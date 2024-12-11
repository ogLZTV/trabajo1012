using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    private Vector2 newPosition;
    public string PositionX;
    public string PositionY;
    public GameObject panel;
    public float positionMinPanel;
    private void Start()
    {
        if (player != null)
        {
            newPosition.x = PlayerPrefs.GetFloat(PositionX, player.transform.position.x);
            newPosition.y = PlayerPrefs.GetFloat(PositionY, player.transform.position.y);
            player.transform.position = newPosition;
        }
        if (player.transform.position.x <= positionMinPanel)
        {
            panel.SetActive(true);
        }
    }
    private void OnDestroy()
    {
        if (player != null)
        {
            PlayerPrefs.SetFloat(PositionX, player.transform.position.x);
            PlayerPrefs.SetFloat(PositionY, player.transform.position.y);
            PlayerPrefs.Save();
        }

    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
    public void Tiempo(float t)
    {
        Time.timeScale = t;
    }
}
