using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< Updated upstream

public class Main_Menu : MonoBehaviour
{
=======
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    public GameObject creditsPanel;
    public GameObject optionsPanel;
    public Light sceneLight;          // Referencia luz
    public AudioSource audioSource;    // Referencia audio
    public Slider lightSlider;         // Slider iluminación
    public Slider soundSlider;         // Slider sonido

    private void Start()
    {
        if (sceneLight != null)
        {
            sceneLight.intensity = PlayerPrefs.GetFloat("LightIntensity", 1.0f);
        }

        if (audioSource != null)
        {
            audioSource.volume = PlayerPrefs.GetFloat("AudioVolume", 1.0f);
        }
    }

>>>>>>> Stashed changes
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
<<<<<<< Updated upstream
}
=======

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("El juego se ha cerrado."); 
    }

    public void ShowCredits()
    {
        creditsPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }

    public void ShowOptions()
    {
        optionsPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }

    public void ShowMainPanel()
    {
        creditsPanel.SetActive(false);
        optionsPanel.SetActive(false);
    }

    // Ajustar la iluminación
    public void AdjustLighting(float intensity)
    {
        if (sceneLight != null)
        {
            sceneLight.intensity = intensity;
            PlayerPrefs.SetFloat("LightIntensity", intensity); // Guarda el valor
        }
    }

    // Ajustar sonido
    public void AdjustSound(float volume)
    {
        if (audioSource != null)
        {
            audioSource.volume = volume;
            PlayerPrefs.SetFloat("AudioVolume", volume); // Guarda el valor
        }
    }
}
>>>>>>> Stashed changes
