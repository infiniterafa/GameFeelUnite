using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [Header("HitEnemyShake")]
    public float HitFrecuency;
    public float HitAmplitude;

    [Range(0f, 1f)]
    public float HitDuration;

    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineBasicMultiChannelPerlin noise;
    public Coroutine shakecoroutine;
    public static CameraManager Instance;



    private void Awake()
    {
        if (Instance = null)
        {
            Instance = this;
        }
    }

    void Start()
    {
       noise = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
       ShakeReset();
    }

    public void HitShake()
    {
        if (shakecoroutine != null)
        {
            StopCoroutine(shakecoroutine);
        }

        shakecoroutine = StartCoroutine(ShakeCoroutine(HitAmplitude, HitFrecuency, HitDuration));
    }

    private void ShakeReset()
    {
        noise.m_FrequencyGain = 0f;
        noise.m_AmplitudeGain = 0f;
    }

    public void CustomShake(float CustomAmplitude, float CustomFrequency, float CustomDuration)

    {
        if (shakecoroutine != null)
        {
            StopCoroutine(shakecoroutine);
        }

        shakecoroutine = StartCoroutine(ShakeCoroutine(CustomAmplitude, CustomFrequency, CustomDuration));
    }

    IEnumerator ShakeCoroutine(float amplitude, float frecuency, float duration)
    {
        noise.m_FrequencyGain = frecuency;
        noise.m_AmplitudeGain = amplitude;

        yield return new WaitForSeconds(duration);
        ShakeReset();
    }
}
