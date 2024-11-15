using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

     public ParticleSystem fireworksEffect; // Sistema de part�culas(Confeti) :D
     public float fireworksDuration = 5f;   // Duraci�n_segundos 


    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        StartCoroutine(PlayFireworks()); 

    }

    //<<<<<<< Updated upstream
    //    public void Start()
    //    {
    //        Cursor.lockState = CursorLockMode.None;
    //=======
    //    public ParticleSystem fireworksEffect; // Sistema de part�culas(Confeti) :D
    //    public float fireworksDuration = 5f;   // Duraci�n_segundos 

    //    private void Start()
    //    {
    //        Cursor.lockState = CursorLockMode.None;
    //        StartCoroutine(PlayFireworks());
    //>>>>>>> Stashed changes
    //    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
//<<<<<<< Updated upstream
//=======

    private IEnumerator PlayFireworks()
    {
        //Iniciar
        if (fireworksEffect != null)
        {
            fireworksEffect.Play(); // Activar
        }

        //Esperar
        yield return new WaitForSeconds(fireworksDuration);

        //Detener 
        if (fireworksEffect != null)
        {
            fireworksEffect.Stop();
        }
    }
//>>>>>>> Stashed changes
}
