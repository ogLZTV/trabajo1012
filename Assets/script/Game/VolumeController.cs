using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider; // Referencia pública al slider
    private const string VolumeKey = "GameVolume"; // Clave para guardar el volumen

    void Start()
    {
        // Cargar el volumen guardado o establecer un valor por defecto
        float savedVolume = PlayerPrefs.GetFloat(VolumeKey, 0.5f);
        AudioListener.volume = savedVolume; // Aplicar el volumen al AudioListener
        if (volumeSlider != null)
        {
            volumeSlider.value = savedVolume; // Sincronizar el slider
        }
    }

    public void OnVolumeChanged()
    {
        if (volumeSlider != null)
        {
            float currentVolume = volumeSlider.value;
            AudioListener.volume = currentVolume; // Ajustar el volumen global
            PlayerPrefs.SetFloat(VolumeKey, currentVolume); // Guardar el volumen en PlayerPrefs
        }
    }
}
