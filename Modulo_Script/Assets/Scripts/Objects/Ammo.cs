using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anmo : MonoBehaviour
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
            if (GameManager.Instance.Bullets < 40)
            {
                GameManager.Instance.Bullets += 5;
                if (GameManager.Instance.Bullets > 40)
                {
                    GameManager.Instance.Bullets = 40;
                 
                }
                postProcessingManager.TweenVignette(0.5f, 0.2f);
                postProcessingManager.ChangeVignetteColor(Color.grey);
                GameManager.Instance.AmmoBullets();
            }
            Destroy(this.gameObject);
        }
    }

}
