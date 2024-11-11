using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot : MonoBehaviour
{
    public float Bullets = 9;
    public

    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0) && GameManager.Instance.Bullets >= 0)
        {
            GameManager.Instance.Bullets--;
            GameManager.Instance.AmmoBullets();
            if (Physics.Raycast(transform.position,
                transform.TransformDirection(Vector3.forward), out hit, 1000))
            {
                Debug.DrawRay(transform.position, transform.
                TransformDirection(Vector3.forward) * hit.distance, Color.red);

                print(hit.transform.name);

                if (hit.transform.CompareTag("Player"))
                {
                    hit.transform.parent.GetComponent<Norm_Ene_Move>().EnemyLifes -= 5;
                }
            }
        }
    }
}
