using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel; // Asigna el Panel desde el Inspector

    private bool isPaused = false;

    void Start()
    {
        pausePanel.SetActive(false); // Oculta el panel de pausa al inicio
        Time.timeScale = 1f; // Asegura que el juego comience sin estar en pausa
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

    // Método para el botón "Volver al Juego"
    public void ResumeGame()
    {
        isPaused = false;
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked; // Bloquea el cursor al reanudar
        Cursor.visible = false; // Oculta el cursor
    }

    // Método para el botón "Ir al Menú"
    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0); // Asegúrate de tener la escena de menú en el índice correcto en Build Settings
    }

    // Método para el botón "Reiniciar"
    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Recarga la escena actual
    }
}