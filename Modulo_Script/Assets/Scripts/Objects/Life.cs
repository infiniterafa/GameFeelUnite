using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
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
            if (GameManager.Instance.PlayerLifes < 100)
            {
                GameManager.Instance.PlayerLifes += 15;
                if (GameManager.Instance.PlayerLifes > 100)
                {
                
                    GameManager.Instance.PlayerLifes = 100;
                }
                postProcessingManager.TweenVignette(0.5f, 0.2f);
                postProcessingManager.ChangeVignetteColor(Color.green);
                GameManager.Instance.LifeHP();
            }
            Destroy(this.gameObject);
        }
    }
}
