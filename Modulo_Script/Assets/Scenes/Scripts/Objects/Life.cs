using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
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
                GameManager.Instance.LifeHP();
            }
            Destroy(this.gameObject);
        }
    }
}
