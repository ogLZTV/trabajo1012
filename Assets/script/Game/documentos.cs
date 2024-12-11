using UnityEngine;

public class documentos : Interactive
{
    public GameObject panel;
    private void Update()
    {
        if (interactive == true)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
