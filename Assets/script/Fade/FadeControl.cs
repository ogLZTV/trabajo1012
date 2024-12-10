using UnityEngine;
using UnityEngine.UI;

public class FadeControl : MonoBehaviour
{
    private Image image;
    public float TimeFade;
    private float time;
    private void Start()
    {
        image = GetComponent<Image>();
        time = 0f;
    }

    private void Update()
    {
        if (time < TimeFade)
        {
            time += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, time / TimeFade);
            image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
        }


    }
}
