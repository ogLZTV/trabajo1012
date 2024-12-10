using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    private Vector2 newPosition;
    public string PositionX;
    public string PositionY;

    private void Start()
    {
        if (player != null)
        {
            newPosition.x = PlayerPrefs.GetFloat(PositionX, player.transform.position.x);
            newPosition.y = PlayerPrefs.GetFloat(PositionY, player.transform.position.y);
            player.transform.position = newPosition;
        }
    }
    private void OnDestroy()
    {
        if (player != null)
        {
            PlayerPrefs.SetFloat(PositionX, player.transform.position.x);
            PlayerPrefs.SetFloat(PositionY, player.transform.position.y);
        }
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}
