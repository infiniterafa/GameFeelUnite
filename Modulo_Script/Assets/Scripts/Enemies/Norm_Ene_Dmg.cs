using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Norm_Ene_Dmg : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            GameManager.Instance.PlayerLifes -= 15;
        }
    }
}
