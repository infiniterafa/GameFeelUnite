using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish_Manager : MonoBehaviour
{
    private void Update()
    {
        FinishCollected();
    }
    public void FinishCollected()
    {
        if (transform.childCount == 0)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
