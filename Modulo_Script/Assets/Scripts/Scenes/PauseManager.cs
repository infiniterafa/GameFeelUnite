using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
//<<<<<<< Updated upstream
    public GameObject pausePanel; // Asigna el Panel desde el Inspector

//>>>>>>> Stashed changes

    private bool isPaused = false;

    void Start()
    {
//<<<<<<< Updated upstream
        pausePanel.SetActive(false); // Oculta el panel de pausa al inicio
        Time.timeScale = 1f; 
//=======
        pausePanel.SetActive(false); // Oculta el panel 
        Time.timeScale = 1f; // Asegura que el juego comience sin estar en pausa
//>>>>>>> Stashed changes
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Tecla para pausar
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f; // Congela el tiempo
            Cursor.lockState = CursorLockMode.None; // Desbloquea el cursor
            Cursor.visible = true; // Hace visible el cursor
        }
        else
        {
            ResumeGame();
        }
    }

    //"Volver al Juego"
    public void ResumeGame()
    {
        isPaused = false;
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked; // Bloquea el cursor al reanudar
        Cursor.visible = false; // Oculta el cursor
    }

    // "Ir al Menú"
    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0); 
    }

    // "Reiniciar"
    public void RestartLevel()
    {
        Time.timeScale = 1f;
//<<<<<<< Updated upstream
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Recarga la escena actual
//=======
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
//>>>>>>> Stashed changes
    }
}