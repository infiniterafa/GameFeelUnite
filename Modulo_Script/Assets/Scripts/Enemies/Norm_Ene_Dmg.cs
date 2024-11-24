using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class Norm_Ene_Dmg : MonoBehaviour
{
    public CameraManager camManager;

    PostProcessingManager postProcessingManager;
    private float postProcessIntensity = 10;
    private float postProcessTweenTime = 10f; 

   public float CustomAmplitude;
   public float CustomFrequency;
   public float CustomDuration;

    void Start()
    {
       postProcessingManager =   PostProcessingManager.instance; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            postProcessingManager.TweenVignette(0.5f, 0.2f);

            collision.transform.DOScale(Vector3.zero, 0.15f);

            GameManager.Instance.PlayerLifes -= 15;
            camManager.CustomShake(CustomAmplitude, CustomFrequency, CustomDuration);
        }
    }
}
