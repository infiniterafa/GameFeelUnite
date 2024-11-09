using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Norm_Ene_Dmg : MonoBehaviour
{
    public CameraManager camManager;

   public float CustomAmplitude;
   public float CustomFrequency;
   public float CustomDuration;

    void Start()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            GameManager.Instance.PlayerLifes -= 15;
            camManager.CustomShake(CustomAmplitude, CustomFrequency, CustomDuration);
        }
    }
}
