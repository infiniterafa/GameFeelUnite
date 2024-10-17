using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast_Ene_Dmg : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            GameManager.Instance.PlayerLifes -= 10;
        }
    }
}
