using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strong_Ene_Dmg : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            GameManager.Instance.PlayerLifes -= 25;
        }
    }
}
