using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anmo : MonoBehaviour
{
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
                GameManager.Instance.AmmoBullets();
            }
            Destroy(this.gameObject);
        }
    }

}
