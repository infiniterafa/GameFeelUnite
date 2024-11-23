using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class PauseManagerTrue: MonoBehaviour
{


    private bool pause
    {
        get
        {
            return _pause;
        }
        set
        {
            _pause = value;
            if (_pause)
            {
                Time.timeScale = 0;
                pauseCanvas.DOFade(0.85f, 0.15f).SetUpdate(true);
            }
            else
            {
                Time.timeScale = 1;
                pauseCanvas.DOFade(0, 0.15f).SetUpdate(true); ;
            }
        }
    }
    private bool _pause;


    public KeyCode pauseKey;
    public CanvasGroup pauseCanvas;



    void Start()
    {

        DontDestroyOnLoad(gameObject);
        pause = false;
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

        pause = !pause;

        if (pause)
        {


            Time.timeScale = 0f; // Congela el tiempo
            Cursor.lockState = CursorLockMode.None; // Desbloquea el cursor
            Cursor.visible = true; // Hace visible el cursor
        }
        else
        {
            ResumeGame();
        }
    }

    // "Volver al Juego"
    public void ResumeGame()
    {
        
        pause = false;

        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked; // Bloquea el cursor al reanudar
        Cursor.visible = false; // Oculta el cursor
    }

    // "Ir al Menú"
    public void GoToMenu()
    {

        TogglePause();
        Cursor.lockState = CursorLockMode.None;
 
        SceneManager.LoadScene(0);
    }

    // "Reiniciar"
    public void RestartLevel()
    {

        TogglePause();
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
