using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class Norm_Ene_Dmg : MonoBehaviour
{
    private CameraManager camManager;

    PostProcessingManager postProcessingManager;
    private float postProcessIntensity = 1;
    private float postProcessTweenTime = 1; 

   public float CustomAmplitude;
   public float CustomFrequency;
   public float CustomDuration;

    void Start()
    {
       postProcessingManager =   PostProcessingManager.instance;
        camManager = CameraManager.Instance;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            postProcessingManager?.TweenVignette(0.5f, 0.2f);
            postProcessingManager.ChangeVignetteColor(Color.red);
            GameManager.Instance.PlayerLifes -= 15;
            camManager.HitShake();
            Debug.Log($"{transform.name} collided with Player");
        }
    }
}
