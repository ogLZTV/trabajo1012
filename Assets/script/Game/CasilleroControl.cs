using UnityEngine;

public class CasilleroControl : Interactive
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && player != null)
        {
            if (player.activeSelf)
            {
                player.SetActive(false);
            }
            else
            {
                player.SetActive(true);
                player=null;
            }
        }
    }
}
