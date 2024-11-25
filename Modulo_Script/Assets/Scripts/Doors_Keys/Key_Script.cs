using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key_Script : MonoBehaviour
{
    public UnityEvent PickKey;

    PostProcessingManager postProcessingManager;
    private float postProcessIntensity = 10;
    private float postProcessTweenTime = 10f;

    void Start()
    {
        postProcessingManager = PostProcessingManager.instance;
    }


    public void OnTriggerEnter(Collider other)
    {
        print(other.transform.name);
        if (other.transform.CompareTag("Player"))
        {
            if (GameManager.Instance.Keys < 20)
            {
                GameManager.Instance.Keys += 1;
                GameManager.Instance.KeysCount();
                postProcessingManager.TweenVignette(0.5f, 0.2f);
                postProcessingManager.ChangeVignetteColor(Color.blue);
            }
            PickKey.Invoke();
        }
    }
}
