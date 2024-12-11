using UnityEngine;

public class CasilleroControl : Interactive
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && player != null&&interactive==true)
        {
            player.SetActive(false);
        }else if (Input.GetKeyDown(KeyCode.E)&&interactive==false&&player!=null)
        {
            player.SetActive(true);
        }
    }
}
